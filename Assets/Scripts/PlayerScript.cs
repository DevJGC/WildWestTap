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
        if (Input.GetMouseButton(0))
        {
           if (gun==false && bullets==0)
             {
            aro.enabled = true;
           }
             else
             {
            aro.enabled = false;
            }

        }
        



    
        
    }
}
