using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
   public static float enemyLife = 100f;
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

   
}
