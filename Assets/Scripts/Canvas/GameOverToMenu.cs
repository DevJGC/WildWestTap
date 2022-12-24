using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Botones del Canvas para cambiar de escena a GamePlay o Menu
public class GameOverToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Si pulsa Escape cambia a escena GamePlay
        if(Input.GetKeyDown(KeyCode.Escape))
        { 
            SceneManager.LoadScene("GamePlay");
        }
        
    }

    // Funcion publica para activar desde el Canvas
    public void GoToGamePlay()
    {
        SceneManager.LoadScene("GamePlay");
    }

    // Funcion publica para activar desde el Canvas
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
