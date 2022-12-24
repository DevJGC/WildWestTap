using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// La barra de energia de los enemigos siempre mira hacia la cámara
public class EnergyBarLookCamera : MonoBehaviour
{
    // Referencia de la camara para poder apuntar hacia ella
    [SerializeField] Camera cam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Rota el eje "forward" Z hacia la cámara para que se vea siempre correctamente
        transform.LookAt(transform.position + cam.transform.rotation * Vector3.forward, cam.transform.rotation * Vector3.up);
        
    }
}
