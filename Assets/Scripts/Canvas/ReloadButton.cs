using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ReloadButton : MonoBehaviour
{
    // Referencia al Player
    [SerializeField] PlayerScript player;
    [SerializeField] Image aro;
    [SerializeField] TMP_Text ammoNumber;
    [SerializeField] TMP_Text levelText;
    [SerializeField] Image energyBarCanvas;
    float energyBar;

    [SerializeField] TMP_Text moneyText;
    int money;

    public int maxBullets = 6;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;
    [SerializeField] AudioClip buttonFail;

    int level;


    // Niveles de mejoras tomadas del player

    int bulletsLevel;
    [SerializeField] Text bulletsLevelText;
    int energyLevel;
    [SerializeField] Text energyLevelText;
    int strengthLevel;
    [SerializeField] Text strengthLevelText;
    int sightLevel; 
    [SerializeField] Text sightLevelText;
    
    void Start()
    {
       level = PlayerPrefs.GetInt("level");
       energyBar = PlayerPrefs.GetInt("energy");
       money = PlayerPrefs.GetInt("money");

        bulletsLevel = PlayerPrefs.GetInt("bulletsLevel");
        energyLevel = PlayerPrefs.GetInt("energyLevel");
        strengthLevel = PlayerPrefs.GetInt("strengthLevel");
        sightLevel = PlayerPrefs.GetInt("sightLevel");


       ReloadCanvas();
       Reload();

    }

    
    void Update()
    {
        
    }

    public void Reload()
    {
       if (player.bulletsPlayer< maxBullets) 
       {
        player.bulletsPlayer ++;
        ReloadCanvas();
        audioSource.PlayOneShot(audioClip);
        
        player.gun = true;
        aro.enabled = false;
       }
       else 
        {
            audioSource.PlayOneShot(buttonFail);
        }

    }

    public void ReloadCanvas()
    {
        int ammo = player.bulletsPlayer;  
        ammoNumber.text = ammo.ToString();
        ammo = PlayerPrefs.GetInt("bullets");
        levelText.text = level.ToString();
        energyBarCanvas.fillAmount = energyBar/100;
        moneyText.text = money.ToString();

        bulletsLevelText.text = bulletsLevel.ToString();
        energyLevelText.text = energyLevel.ToString();
        strengthLevelText.text = strengthLevel.ToString();
        sightLevelText.text = sightLevel.ToString();
        

    }


}
