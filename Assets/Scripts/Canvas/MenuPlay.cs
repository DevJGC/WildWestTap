using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPlay : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            
            Application.Quit();
           
            UnityEditor.EditorApplication.isPlaying = false;
        
        }

        if(Input.GetKeyDown(KeyCode.Return))
        {
            
            PlayGame();
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
