using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadButton : MonoBehaviour
{
    // Referencia al Player
    [SerializeField] PlayerScript player;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Reload()
    {
        player.bullets = 6;
        player.gun = true;
    }


}
