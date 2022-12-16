using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookToPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float m_Speed = 10f;
    [SerializeField] Rigidbody m_Rigidbody;
    
   // [SerializeField] ShotPoint shotPoint;
    

    void Start()
    {
        transform.rotation = Quaternion.LookRotation(player.position - transform.position);
    }

    // Update is called once per frame
    void Update()
    {
    
        m_Rigidbody.velocity = transform.forward * m_Speed;
        
    }


}
