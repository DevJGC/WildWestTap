using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBarLookCamera : MonoBehaviour
{
    [SerializeField] Camera cam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.LookAt(transform.position + cam.transform.rotation * Vector3.forward, cam.transform.rotation * Vector3.up);

        //transform.forward = cam.transform.forward;
        
    }
}
