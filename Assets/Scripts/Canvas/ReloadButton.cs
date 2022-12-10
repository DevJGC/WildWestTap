using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ReloadButton : MonoBehaviour
{
    // Referencia al Player
    [SerializeField] PlayerScript player;
    [SerializeField] Image aro;

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
        audioSource.PlayOneShot(audioClip);
        player.bullets ++;
        player.gun = true;
        aro.enabled = false;
       }
       else 
        {
            audioSource.PlayOneShot(buttonFail);
        }

    }


}
