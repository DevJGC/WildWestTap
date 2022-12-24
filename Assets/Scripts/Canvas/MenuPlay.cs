using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Para cambiar de Escena desde la Escena Menu y su Canvas
public class MenuPlay : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        // Si se pulsa Escape sale del editor y del juego
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            
            Application.Quit();
           
           // UnityEditor.EditorApplication.isPlaying = false;
        
        }

        // Si se pulsa Enter se cambia de Escena
        if(Input.GetKeyDown(KeyCode.Return))
        {
            
            PlayGame();
        }
    }

    // Metodo para cambiar de Escena desde el Canvas
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
