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

    [SerializeField] TMP_Text moneyTextCanvas;
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
    
    void Awake()
    {
      // Carga todas las variable
       level = PlayerPrefs.GetInt("level");
       energyBar = PlayerPrefs.GetInt("energy");
       player.money = PlayerPrefs.GetInt("money");

        bulletsLevel = PlayerPrefs.GetInt("bulletsLevel");
        energyLevel = PlayerPrefs.GetInt("energyLevel");
        strengthLevel = PlayerPrefs.GetInt("strengthLevel");
        sightLevel = PlayerPrefs.GetInt("sightLevel");


       // Mejoras número de balas (máximo cargador pistola)
       if(bulletsLevel==2) maxBullets = 12;
         if(bulletsLevel==3) maxBullets = 18;
            if(bulletsLevel==4) maxBullets = 24;


        // Mejoras energia (vida player)
        if(energyLevel==2) energyBar = 20;
         if(energyLevel==3) energyBar = 30;
            if(energyLevel==4) energyBar = 40;
              if(energyLevel==5) energyBar = 50;
                if(energyLevel==6) energyBar = 60;
                 if(energyLevel==7) energyBar = 70;  
                    if(energyLevel==8) energyBar = 80;
                        if(energyLevel==9) energyBar = 90;
                            if(energyLevel==10) energyBar = 100;

        // Mejoras fuerza (calibre balas)
        if(strengthLevel==2) player.strength = 20;
         if(strengthLevel==3) player.strength = 30;
            if(strengthLevel==4) player.strength = 40;
                if(strengthLevel==5) player.strength = 50;
                 if(strengthLevel==6) player.strength = 60;
                   if(strengthLevel==7) player.strength = 70;
                    if(strengthLevel==8) player.strength = 80;
                     if(strengthLevel==9) player.strength = 90;
                        if(strengthLevel==10) player.strength = 100;



        // Mejoras visión (ampliar vision camara)
        if(sightLevel==2) player.sight = 58;
         if(sightLevel==3) player.sight = 56;
            if(sightLevel==4) player.sight = 54;
             if(sightLevel==5) player.sight = 52;
              if(sightLevel==6) player.sight = 50;


       // Actualiza el canvas y la recarga de pistola
       ReloadCanvas();
       Reload();

    }

    
    void Update()
    {
        
    }

    // Boton de recarga de la pistola
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

    // Actualiza el canvas
    public void ReloadCanvas()
    {
        int ammo = player.bulletsPlayer;  
        ammoNumber.text = ammo.ToString();
        ammo = PlayerPrefs.GetInt("bullets");
        levelText.text = level.ToString();
        energyBarCanvas.fillAmount = energyBar/100;
        moneyTextCanvas.text = player.money.ToString();

        bulletsLevelText.text = bulletsLevel.ToString();
        energyLevelText.text = energyLevel.ToString();
        strengthLevelText.text = strengthLevel.ToString();
        sightLevelText.text = sightLevel.ToString();
        

    }


}
