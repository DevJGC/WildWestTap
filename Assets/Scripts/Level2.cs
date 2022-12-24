using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Este Script activa los niveles 0 y 1 para que el nivel 2 sea una mezcla de ambos
public class Level2 : MonoBehaviour
{
    // Referencia de los niveles
    [SerializeField] GameObject[] levelGroup;

    void Start()
    {
        ActivateLevels();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Activa las referencias de los niveles
    public void ActivateLevels()
    {
        for (int i = 0; i < levelGroup.Length; i++)
        {
            levelGroup[i].SetActive(true);
        }
    }
}
