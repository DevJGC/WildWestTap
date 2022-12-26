using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Este Script se encarga de cargar los datos de la partida guardada, y mostrarlos en el canvas de GameOver
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

    // Sonidos
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip buySound;

    
    void Awake()
    {

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




        // Sincroniza el canvas
        SynVariablesToCanvas();


        
    }

    void Start()
    {
      // Activa botones de compra
      ActiveButtonsBuy();

    }


    void Update()
    {

        
    }


    // Funciones de actualización de variables y Canvas
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

    // Si no llegas a 100 dolares, desactiva botones de compra o los activa si es igual o mayor que 100
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

    // Si el nivel de mejora es igual o maximo, desactiva el boton de compra
    if (bulletsLevel>=4) bulletButton.interactable = false;
    
    if (energyLevel>=10) energyButton.interactable = false;
    
    if (strengthLevel>=10) strengthButton.interactable = false;
    
    if (sightLevel>=6) sightButton.interactable = false;
    

  }

  // Funciones de compra
  public void Buy()
  {
    audioSource.PlayOneShot(buySound);
    money -= 100;
    moneyText.text = money.ToString();
    PlayerPrefs.SetInt("money", money);
    ActiveButtonsBuy();
  }

  
  // Funcion publica del canvas para comprar mas municion
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

  // Funcion publica del canvas para comprar mas energia
  public void BuyEnergy()
  {
    energyLevel ++;
    //energyMax += 10;
    //energy += 10;
    //energyText.text = energy.ToString();
    //energyMaxText.text = energyMax.ToString();
    energyLevelText.text = energyLevel.ToString();
    //PlayerPrefs.SetInt("energy", energy);
    //PlayerPrefs.SetInt("energyMax", energyMax);
    PlayerPrefs.SetInt("energyLevel", energyLevel);
  }

  // Funcion publica del canvas para comprar mas fuerza o calibre
  public void BuyStrength()
  {
    strengthLevel ++;
    //strengthMax += 10;
    //strength += 10;
    //strengthText.text = strength.ToString();
    //strengthMaxText.text = strengthMax.ToString();
    strengthLevelText.text = strengthLevel.ToString();
    //PlayerPrefs.SetInt("strength", strength);
    //PlayerPrefs.SetInt("strengthMax", strengthMax);
    PlayerPrefs.SetInt("strengthLevel", strengthLevel);
  }

  // Funcion publica del canvas para comprar mas vision
  public void BuySight()
  {
    sightLevel ++;
    //sightMax += 10;
    //sight += 10;
    //sightText.text = sight.ToString();
    //sightMaxText.text = sightMax.ToString();
    sightLevelText.text = sightLevel.ToString();
    //PlayerPrefs.SetInt("sight", sight);
    //PlayerPrefs.SetInt("sightMax", sightMax);
    PlayerPrefs.SetInt("sightLevel", sightLevel);
  }
  



}
