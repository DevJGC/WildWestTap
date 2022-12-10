using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] Image aro;

    public bool gun;

    public int bullets=6;
    
    void Start()
    {
       
        
    }

    
    void Update()
    {

        if (bullets==0)
        {
            ReloadGun();
        }

    
        
    }

    public void ReloadGun()
    {
        aro.enabled = true; 
    }
}
