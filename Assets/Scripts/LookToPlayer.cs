using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Este Script se encarga de que el enemigo se mueva o mire hacia el jugador
public class LookToPlayer : MonoBehaviour
{

    // Velocidad enemigo
    [SerializeField] float m_Speed;
    // Posicion del enemigo segun la ruta
    [SerializeField] private Transform[] m_Waypoints;
    [SerializeField] private int m_CurrentWaypointIndex=0;
    
    // Referencia al script del enemigo
    [SerializeField] EnemyScript enemyScript;
    

    void Start()
    {
        

    }


    void Update()
    {
        // Si el enemigo tiene energia y la ruta no ha terminado lo mueve hacia el siguiente punto 
        if (m_CurrentWaypointIndex < m_Waypoints.Length  && enemyScript.energyEnemy>0)
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
