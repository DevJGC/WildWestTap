using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class PlayerScript : MonoBehaviour
{
    [SerializeField] Image aro;

    public bool gun;

    public int bulletsPlayer;




    // Variables primarias estaticas (de inicio)
    //int bullets;
    public int energy;
    public int strength;
    public int sight;

    // Variables secundarias estaticas (max)
    public int bulletsMax;
    public int energyMax;
    public int strengthMax;
    public int sightMax;

    // Variables de nivel (niveles de mejoras)

    public int bulletsLevel;
    public int energyLevel;
    public int strengthLevel;
    public int sightLevel;

    // Variables de experiencia (del juego)
    public int level;
    public int money;
    
    void Awake()
    {
      
        // Ojo con bullet y bulletsPlayer
        bulletsPlayer = PlayerPrefs.GetInt("bullets");
        
        energy = PlayerPrefs.GetInt("energy");
        strength = PlayerPrefs.GetInt("strength");
        sight = PlayerPrefs.GetInt("sight");

        bulletsMax = PlayerPrefs.GetInt("bulletsMax");
        energyMax = PlayerPrefs.GetInt("energyMax");
        strengthMax = PlayerPrefs.GetInt("strengthMax");
        sightMax = PlayerPrefs.GetInt("sightMax");

        bulletsLevel = PlayerPrefs.GetInt("bulletsLevel");
        energyLevel = PlayerPrefs.GetInt("energyLevel");
        strengthLevel = PlayerPrefs.GetInt("strengthLevel");
        sightLevel = PlayerPrefs.GetInt("sightLevel");

        level = PlayerPrefs.GetInt("level");
        money = PlayerPrefs.GetInt("money");

    }
    void Start()
    {
       
        
    }

    
    void Update()
    {

        if (bulletsPlayer<=0)
        {
            ReloadGun();
        }



        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SyncVariables();
            SceneManager.LoadScene("Menu");
               
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SyncVariables();
            SceneManager.LoadScene("GameOver");
        }

       
        
        

    
        
    }

    public void ReloadGun()
    {
        aro.enabled = true; 
    }


    public void SyncVariables()
    {
        PlayerPrefs.SetInt("bullets", bulletsPlayer);
        PlayerPrefs.SetInt("energy", energy);
        PlayerPrefs.SetInt("strength", strength);
        PlayerPrefs.SetInt("sight", sight);

        PlayerPrefs.SetInt("bulletsMax", bulletsMax);
        PlayerPrefs.SetInt("energyMax", energyMax);
        PlayerPrefs.SetInt("strengthMax", strengthMax);
        PlayerPrefs.SetInt("sightMax", sightMax);

        PlayerPrefs.SetInt("bulletsLevel", bulletsLevel);
        PlayerPrefs.SetInt("energyLevel", energyLevel);
        PlayerPrefs.SetInt("strengthLevel", strengthLevel);
        PlayerPrefs.SetInt("sightLevel", sightLevel);

        PlayerPrefs.SetInt("level", level);
        PlayerPrefs.SetInt("money", money);


    }





}


