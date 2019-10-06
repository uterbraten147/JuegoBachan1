using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public float SpeedMove;
    public Animator EnemyAnim;
    bool walk = false;
    bool attack = false;
    bool distanciaCheck = false;


    float distancia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        distancia = Vector3.Distance( new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z) , this.transform.position);

        if(distancia <= 2) 
        {
            distanciaCheck = true;
        }
        else
        {
            distanciaCheck = false;
           
        }


        if (!distanciaCheck)
        {
            walk = true;
            attack = false;
            transform.LookAt(player.transform);
            transform.position += transform.forward * SpeedMove * Time.deltaTime;
        }
        else if (distanciaCheck)
        {
            walk = false;
            attack = true;
        }



        EnemyAnim.SetBool("Walking", walk);
        EnemyAnim.SetBool("Attack", attack);








    }
}
