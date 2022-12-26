using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


// Este es el Script principal del Player
public class PlayerScript : MonoBehaviour
{
    // Referencia a la imagen del aro de avisa de falta de municion
    [SerializeField] Image aro;

    public bool gun;

    public int bulletsPlayer=6;




    // Variables primarias estaticas (de inicio)
    public int bullets=6;
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

    // Variables de nivel y dinero
    public int level;
    public int money;
    
    void Awake()
    {
      
        // Carga todas las variables guardadas en el PlayerPrefs
       // bulletsPlayer = PlayerPrefs.GetInt("bullets");
        
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
        strength = strengthLevel * 10;

        //Revisar ESTAS 2 LINEAS!!!
        //sight = sightLevel * 10;
       // energy = energyLevel * 10;

        

        
    }

    
    void Update()
    {
        // Si no hay municion, se activa el aro de aviso
        if (bulletsPlayer<=0)
        {
            ReloadGun();
        }


        // Si se pulsa la tecla Escape, se vuelve al menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SyncVariables();
            SceneManager.LoadScene("Menu");
               
        }

        // Si se pulsa la tecla Enter, va al Inventario
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SyncVariables();
            SceneManager.LoadScene("GameOver");
        }

        
    }

    // Funcion que activa el aro de aviso de falta de municion
    public void ReloadGun()
    {
        aro.enabled = true; 
    }


    // Funcion que guarda todas las variables en el PlayerPrefs
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


