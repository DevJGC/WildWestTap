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
    [SerializeField] TMP_Text energyText;
    int strength;
    [SerializeField] TMP_Text strengthText;
    int sight;
    [SerializeField] TMP_Text sightText;

    // Variables secundarias estaticas (max)
    int bulletsMax;
    [SerializeField] TMP_Text bulletMaxText;
    int energyMax;
    [SerializeField] TMP_Text energyMaxText;
    int strengthMax;
    [SerializeField] TMP_Text strengthMaxText;
    int sightMax;
    [SerializeField] TMP_Text sightMaxText;


    // Variables de nivel (niveles de mejoras)

    int bulletsLevel;
    [SerializeField] TMP_Text bulletLevelText;
    int energyLevel;
    [SerializeField] TMP_Text energyLevelText;

    int strengthLevel;
    [SerializeField] TMP_Text strengthLevelText;

    int sightLevel;
    [SerializeField] TMP_Text sightLevelText;


    // Variables de experiencia (del juego)
    int level;
    [SerializeField] TMP_Text levelText;
    int money;
    [SerializeField] TMP_Text moneyText;


    // Botones de compra
    [SerializeField] Button bulletButton;
    [SerializeField] Button energyButton;
    [SerializeField] Button strengthButton;
    [SerializeField] Button sightButton;



    
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
      //  Debug.Log("Balas " + bullets);

        
    }

    void Start()
    {
      ActiveButtonsBuy();

    }


    void Update()
    {

        
    }


    // Funciones de actualización de variables
   public void SynVariablesToCanvas()
   {
        
        bulletText.text = bullets.ToString();
        energyText.text = energy.ToString();
        strengthText.text = strength.ToString();
        sightText.text = sight.ToString();
        bulletMaxText.text = bulletsMax.ToString();
        energyMaxText.text = energyMax.ToString();
        strengthMaxText.text = strengthMax.ToString();
        sightMaxText.text = sightMax.ToString();
        bulletLevelText.text = bulletsLevel.ToString();
        energyLevelText.text = energyLevel.ToString();
        strengthLevelText.text = strengthLevel.ToString();
        sightLevelText.text = sightLevel.ToString();
        
        
        levelText.text = level.ToString();
        moneyText.text = money.ToString();
              
   }

  public void ActiveButtonsBuy()
  {

    if (money < 100)
    {

      bulletButton.interactable = false;
      energyButton.interactable = false;
      strengthButton.interactable = false;
      sightButton.interactable = false;
    }
    else
    {
      bulletButton.interactable = true;
      energyButton.interactable = true;
      strengthButton.interactable = true;
      sightButton.interactable = true;
    }

    if (bulletsLevel>=4) bulletButton.interactable = false;
    
    if (energyLevel>=10) energyButton.interactable = false;
    
    if (strengthLevel>=10) strengthButton.interactable = false;
    
    if (sightLevel>=6) sightButton.interactable = false;
    

  }

  public void Buy()
  {
    money -= 100;
    moneyText.text = money.ToString();
    PlayerPrefs.SetInt("money", money);
    ActiveButtonsBuy();
  }

  public void BuyBullets()
  {
    bulletsLevel++;
    //bulletsMax += 10;
    //bullets += 10;
    //bulletText.text = bullets.ToString();
    //bulletMaxText.text = bulletsMax.ToString();
    bulletLevelText.text = bulletsLevel.ToString();
    //PlayerPrefs.SetInt("bullets", bullets);
    //PlayerPrefs.SetInt("bulletsMax", bulletsMax);
    PlayerPrefs.SetInt("bulletsLevel", bulletsLevel);

  }



}
