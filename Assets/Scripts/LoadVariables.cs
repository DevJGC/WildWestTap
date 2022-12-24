using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadVariables : MonoBehaviour
{
    // Detecta la primera carga
    [SerializeField] int firstLoad;

    // Variables primarias estaticas (de inicio)
    int bullets;
    int energy;
    int strength;
    int sight;

    // Variables secundarias estaticas (max)
    int bulletsMax;
    int energyMax;
    int strengthMax;
    int sightMax;

    // Variables de nivel (niveles de mejoras)

    int bulletsLevel;
    int energyLevel;
    int strengthLevel;
    int sightLevel;

    // Variables de experiencia (del juego)
    int level;
    int money;

    void Awake()
    {
        // Si no existe la variable firstLoad, se crea y se asigna valor 0
        if (!PlayerPrefs.HasKey("firstLoad"))
        {
            PlayerPrefs.SetInt("firstLoad", 0);
        }

        // Si firstLoad es 0, se crea las variables, y si no existen, les asigna valor inicial
        if (PlayerPrefs.GetInt("firstLoad") == 0)
        {
            PlayerPrefs.SetInt("bullets", 6);
            PlayerPrefs.SetInt("energy", 10);
            PlayerPrefs.SetInt("strength", 10);
            PlayerPrefs.SetInt("sight", 60);

            PlayerPrefs.SetInt("bulletsMax", 24);
            PlayerPrefs.SetInt("energyMax", 100);
            PlayerPrefs.SetInt("strengthMax", 100);
            PlayerPrefs.SetInt("sightMax", 50);

            PlayerPrefs.SetInt("bulletsLevel", 1);
            PlayerPrefs.SetInt("energyLevel", 1);
            PlayerPrefs.SetInt("strengthLevel", 1);
            PlayerPrefs.SetInt("sightLevel", 1);

            PlayerPrefs.SetInt("level", 0);
            PlayerPrefs.SetInt("money", 0);

            // Se cambia el valor de firstLoad a 1
            PlayerPrefs.SetInt("firstLoad", 1);
            firstLoad = 1;

        }


    }

    
    void Start()
    {
        // Crea las variables, y si no existen, les asigna valor inicial
     
    
        PlayerPrefs.GetInt("bullets", 6);
        PlayerPrefs.GetInt("energy", 10);
        PlayerPrefs.GetInt("strength", 10);
        PlayerPrefs.GetInt("sight", 60);

        PlayerPrefs.GetInt("bulletsMax", 24);
        PlayerPrefs.GetInt("energyMax", 100);
        PlayerPrefs.GetInt("strengthMax", 100);
        PlayerPrefs.GetInt("sightMax", 50);

        PlayerPrefs.GetInt("bulletsLevel", 1);
        PlayerPrefs.GetInt("energyLevel", 1);
        PlayerPrefs.GetInt("strengthLevel", 1);
        PlayerPrefs.GetInt("sightLevel", 1);

        PlayerPrefs.GetInt("level", 0);
        PlayerPrefs.GetInt("money", 0);
    


        // Salva las variables

        firstLoad = PlayerPrefs.GetInt("firstLoad");

        bullets = PlayerPrefs.GetInt("bullets");
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


    // Si se pulsa R se resetean todos los valores (para testeo)
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            
        PlayerPrefs.SetInt("bullets", 6);
        PlayerPrefs.SetInt("energy", 10);
        PlayerPrefs.SetInt("strength", 10);
        PlayerPrefs.SetInt("sight", 60);

        PlayerPrefs.SetInt("bulletsMax", 24);
        PlayerPrefs.SetInt("energyMax", 100);
        PlayerPrefs.SetInt("strengthMax", 100);
        PlayerPrefs.SetInt("sightMax", 50);

        PlayerPrefs.SetInt("bulletsLevel", 1);
        PlayerPrefs.SetInt("energyLevel", 1);
        PlayerPrefs.SetInt("strengthLevel", 1);
        PlayerPrefs.SetInt("sightLevel", 1);

        PlayerPrefs.SetInt("level", 0);
        PlayerPrefs.SetInt("money", 0);

        }

        
    }
}
