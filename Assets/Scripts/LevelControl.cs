using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    [SerializeField] int level;
    public int kills;
    [SerializeField] TextMeshProUGUI levelNumber;
    [SerializeField] TextMeshProUGUI levelTitleText;
    [SerializeField] TextMeshProUGUI levelSubTitleText;

    [SerializeField] GameObject levelCompleteCanvas;
    [SerializeField] PlayerScript playerScript;

    // Grupos Objects Levels
    [SerializeField] GameObject[] levelGroup;
    

    
    void Start()
    {
        // Carga la variable Level y la actualiza en el canvas
        level = PlayerPrefs.GetInt("level");
        levelNumber.text = level.ToString();

        // Llama al metodo enviando el nivel actual
        LevelNumber(level);

        // Llama al metodo enviando el titulo del nivel
        ActivateLevels();
    }

    
    void Update()
    {
        
    }

    // Segun el nivel, asigna unos Strings para el titulo y subtitulo
    public void LevelNumber(int levelNumber)
    {
        if (levelNumber == 0)
        {
            levelTitleText.text = "Tutorial";
            levelSubTitleText.text = "Eliminate all guards";
        }

        if (levelNumber == 1)
        {
            levelTitleText.text = "Clean";
            levelSubTitleText.text = "Remove the branches";
        }

        if (levelNumber == 2)
        {
            levelTitleText.text = "Eliminate";
            levelSubTitleText.text = "Everything that moves";
        }
    }

    // Recoge el texto del titulo
    public void LevelTitle(string title)
    {
        levelTitleText.text = title;
    }

    // Recoge el texto del subtitulo
    public void LevelSubTitle(string subTitle)
    {
        levelSubTitleText.text = subTitle;
    }

    // Cuenta las muertes de los enemigos segun el nivel en el que estemos
    public void KillsCounter()
    {
        kills++;
        if (kills == 4 && level == 0 || kills == 4 && level == 1)
        {
            levelCompleteCanvas.SetActive(true);
        }

        if (kills == 8 && level == 2)
        {
            levelCompleteCanvas.SetActive(true);
        }
    }

    // Carga el siguiente nivel
    public void NextLevel()
    {
        //levelNumber = PlayerPrefs.GetInt("level");
        level ++;
        playerScript.level = level;
        PlayerPrefs.SetInt("level", level);
        playerScript.SyncVariables();
        //Debug.Log(level);
        SceneManager.LoadScene("GameOver");

    }

    // Activa los grupos de objetos segun el nivel
    public void ActivateLevels()

    {
        for (int i = 0; i < levelGroup.Length; i++)
        {
            if (i == level)
            {
                levelGroup[i].SetActive(true);
            }
            else
            {
                levelGroup[i].SetActive(false);
            }
        }
    }

    

        
}
