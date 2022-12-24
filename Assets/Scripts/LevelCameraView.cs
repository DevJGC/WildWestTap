using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Este Script se encarga del zoom de la camara segun el nivel de mejora
public class LevelCameraView : MonoBehaviour
{
    
    [SerializeField] PlayerScript player;
    [SerializeField] Camera camara;
    [SerializeField] float view = 60f;


    void Start()
    {
        camara = GetComponent<Camera>();
        player = FindObjectOfType<PlayerScript>();

    // Carga el valor actual del zoom/nivel de la camara y lo aplica a la camara
        view = player.sight;
        camara.fieldOfView = view;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
