using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    public float enemyLife = 100f;
    private bool hitbool;
    bool daño= false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {

        if (enemyLife <= 0)
        {
            Destroy(this.gameObject);
        }

    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.CompareTag("AttackBox"))
        {
            Debug.Log("Entroasies");
            enemyLife -= 20;
            
        }
    }
    

}
