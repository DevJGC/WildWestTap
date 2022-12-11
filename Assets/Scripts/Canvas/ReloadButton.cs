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

    public int maxBullets = 6;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;
    [SerializeField] AudioClip buttonFail;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Reload()
    {
       if (player.bullets< maxBullets) 
       {
        player.bullets ++;
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

    public void ReloadCanvas()
    {
        int ammo = player.bullets;  
        ammoNumber.text = ammo.ToString();

    }


}
