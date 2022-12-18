using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelControl : MonoBehaviour
{
    [SerializeField] int level;
    [SerializeField] TextMeshProUGUI levelNumber;
    
    void Start()
    {
        level = PlayerPrefs.GetInt("level");
        levelNumber.text = level.ToString();
        
    }

    
    void Update()
    {
        
    }
}
