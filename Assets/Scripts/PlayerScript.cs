using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] Image aro;

    public bool gun;

    public int bulletsPlayer;
    
    void Awake()
    {
      
       bulletsPlayer = PlayerPrefs.GetInt("bullets");

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

        PlayerPrefs.SetInt("bullets", bulletsPlayer);
        
        

    
        
    }

    public void ReloadGun()
    {
        aro.enabled = true; 
    }





}


