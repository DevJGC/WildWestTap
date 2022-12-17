using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookToPlayer : MonoBehaviour
{
    //[SerializeField] Transform player;

    [SerializeField] float m_Speed;
    [SerializeField] private Transform[] m_Waypoints;
    [SerializeField] private int m_CurrentWaypointIndex=0;
    
    [SerializeField] ShotPoint shotPoint;
    
    

    

    void Start()
    {
        

    }


    void Update()
    {
        if (m_CurrentWaypointIndex < m_Waypoints.Length  && shotPoint.energyEnemy>0)
        {
            transform.LookAt(m_Waypoints[m_CurrentWaypointIndex].position);
            transform.position = Vector3.MoveTowards(transform.position, m_Waypoints[m_CurrentWaypointIndex].position, m_Speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, m_Waypoints[m_CurrentWaypointIndex].position) < 0.1f)
            {
                m_CurrentWaypointIndex++;
            }
        }
        else
        {
            m_CurrentWaypointIndex = 0;
        }
       

        
    }


}
