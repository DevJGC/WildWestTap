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
        level = PlayerPrefs.GetInt("level");
        levelNumber.text = level.ToString();

        LevelNumber(level);

        ActivateLevels();

        
    }

    
    void Update()
    {
        
    }

    public void LevelNumber(int levelNumber)
    {
        if (levelNumber == 0)
        {
            levelTitleText.text = "Tutorial";
            levelSubTitleText.text = "Eliminate all guards";
        }
    }

    public void LevelTitle(string title)
    {
        levelTitleText.text = title;
    }

    public void LevelSubTitle(string subTitle)
    {
        levelSubTitleText.text = subTitle;
    }

    public void KillsCounter()
    {
        kills++;
        if (kills == 4 && level == 0)
        {
            levelCompleteCanvas.SetActive(true);
        }
    }


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
