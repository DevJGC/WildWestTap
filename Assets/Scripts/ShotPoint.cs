using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotPoint : MonoBehaviour
{
    // Referencia al Player
    [SerializeField] PlayerScript player;
    // Variable booleana para saber si el jugador tiene balas
    bool isGun;
    int bullets;
    int money;

    // Referencia a la escena el colisionador del ratón
    [SerializeField] GameObject pointClick;
    // Referencia partículas tiro click
    [SerializeField] ParticleSystem shotParticles;
    // Posición dónde se hace click
    Vector3 worldPosition;

    // Referencia al sonido
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip failShotSound;
    [SerializeField] AudioClip gunShotSound;

    // Actualiza Canvas Disparos y Balas
    [SerializeField] ReloadButton canvasScript;

    // Enemigo
    public bool isEnemy;
    [SerializeField] ParticleSystem dollarParticles;
    public float energyEnemy=1f;
    [SerializeField] Image enemyBarCanvas;

    [SerializeField] Animator enemyAnim;
    [SerializeField] AudioClip coin;
    [SerializeField] AudioClip dead;

    

    

    // No utilizado por ahora
    void Start()
    {
      if (isEnemy==true) 
      {
        enemyBarCanvas.fillAmount = energyEnemy;
      }
      



    }
 
    // Busca dónde está el ratón sobre el objeto colisionador
    void Update()
    {

        isGun = player.gun;
        bullets = player.bulletsPlayer;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitData;
        if(Physics.Raycast(ray, out hitData, 1000))
            {
                worldPosition = hitData.point;
            }
    }

    // Si se hace click en el objeto colisionador, se reproduce el sonido y las partículas
    public void OnMouseDown()
    {
        enemySync();

        if (isGun==true)
        {
        bullets--;
        player.bulletsPlayer = bullets;
        audioSource.PlayOneShot(gunShotSound);
        pointClick.transform.position = worldPosition;
        shotParticles.Play();
        audioSource.PlayOneShot(coin);
        }
        else
        {
            audioSource.PlayOneShot(failShotSound);
        }

        if (bullets==0)
        {   
            isGun=false;
            player.gun = isGun;

        }

        canvasScript.ReloadCanvas();
        

    }

    public void enemySync()
    {

        if(energyEnemy <= 0.001f && isEnemy==true)
        {
            audioSource.PlayOneShot(dead);
            energyEnemy = 0f;
            
            enemyAnim.SetTrigger("Death");
            Destroy(gameObject,2f);
            isEnemy = false;
            
        }

        if (isEnemy==true && bullets>0)
        {
            //enemyAnim.SetTrigger("Mini_Death");
            player.money ++;
            dollarParticles.Play();
            energyEnemy = energyEnemy -0.1f;

            enemyBarCanvas.fillAmount = energyEnemy;

            
            //Debug.Log(player.money);
            //player.bulletsPlayer = bullets;
            //player.gun = isGun;
            //canvasScript.ReloadCanvas();
        }
       
    }



}
