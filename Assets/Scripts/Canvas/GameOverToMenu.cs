using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            
            SceneManager.LoadScene("GamePlay");
        }
        
    }

    public void GoToGamePlay()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
