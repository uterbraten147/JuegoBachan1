using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingPlayer : MonoBehaviour
{
    bool daño = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (daño)
        {
            HealthEnemy.enemyLife -= 20;

            Debug.Log("vida del enemigo: " + HealthEnemy.enemyLife);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            daño = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            daño = false;
        }

    }
}
