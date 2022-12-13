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
       ReloadCanvas();
       Reload();
    }

    
    void Update()
    {
        
    }

    public void Reload()
    {
       if (player.bulletsPlayer< maxBullets) 
       {
        player.bulletsPlayer ++;
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
        int ammo = player.bulletsPlayer;  
        ammoNumber.text = ammo.ToString();
        ammo = PlayerPrefs.GetInt("bullets");

    }


}
