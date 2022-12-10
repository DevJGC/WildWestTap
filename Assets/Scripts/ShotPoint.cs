using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotPoint : MonoBehaviour
{
    // Referencia al Player
    [SerializeField] PlayerScript player;
    bool isGun;

    // Referencia a la escena el colisionador del ratón
    [SerializeField] GameObject pointClick;
    // Referencia partículas tiro click
    [SerializeField] ParticleSystem shotParticles;
    // Posición dónde se hace click
    Vector3 worldPosition;

    // No utilizado por ahora
    void Start()
    {
       

    }
 
    // Busca dónde está el ratón sobre el objeto colisionador
    void Update()
    {

        isGun = player.gun;

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
        //audioSource.PlayOneShot(failSound);
        pointClick.transform.position = worldPosition;
        shotParticles.Play();

        }

    }


}
