using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Este Script oculta el Canvas tras 3 segundos despues de aparecer
public class AutoHideCanvas : MonoBehaviour
{
    // Referencia al canvas
    [SerializeField] GameObject canvas;

    void Start()
    {
        // Activamos el Canvas y tras 3 segundos se desactiva
        canvas.SetActive(true);
        Invoke("HideCanvas", 3f);

    }

    void Update()
    {
        
    }

    // Metodo para desactivar el canvas
    public void HideCanvas()
    {
        canvas.SetActive(false);
    }
}
