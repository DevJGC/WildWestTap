using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoHideCanvas : MonoBehaviour
{
    [SerializeField] GameObject canvas;

    void Start()
    {
        canvas.SetActive(true);
        Invoke("HideCanvas", 3f);

    }

    void Update()
    {
        
    }

    public void HideCanvas()
    {
        canvas.SetActive(false);
    }
}
