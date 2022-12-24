using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// Este Script detecta el punto del disparo
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

    

    // No utilizado por ahora
    void Start()
    {



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

        if (isGun==true)
        {
        bullets--;
        player.bulletsPlayer = bullets;
        audioSource.PlayOneShot(gunShotSound);
        pointClick.transform.position = worldPosition;
        shotParticles.Play();
        //audioSource.PlayOneShot(coin);
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


}
