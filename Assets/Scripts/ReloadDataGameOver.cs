using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ReloadDataGameOver : MonoBehaviour
{
    // Variables primarias estaticas (de inicio)
    int bullets;
    [SerializeField] TMP_Text bulletText;
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
        // Crea las variables, y si no existen, les asigna valor inicial
     
    

    


        // Salva las variables

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



        


        // Muestra variables por consola

         
        // Debug.Log("Energía " + energy);
        // Debug.Log("Fuerza " + strength);
        // Debug.Log("Visión " + sight);

        // Debug.Log("Balas Max " + bulletsMax);
        // Debug.Log("Energía Max " + energyMax);
        // Debug.Log("Fuerza Max " + strengthMax);
        // Debug.Log("Visión Max " + sightMax);


        // Debug.Log("Balas Level " + bulletsLevel);
        // Debug.Log("Energía Level " + energyLevel);
        // Debug.Log("Fuerza Level " + strengthLevel);
        // Debug.Log("Visión Level " + sightLevel);


        // Debug.Log("Nivel " + level);
        // Debug.Log("Dinero " + money);



        
        SynVariablesToCanvas();
        Debug.Log("Balas " + bullets);

        
    }

    void Update()
    {

        
    }


    // Funciones de actualización de variables
   public void SynVariablesToCanvas()
   {
        
        bulletText.text = bullets.ToString();
       

   }
}
