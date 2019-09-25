using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAT_GroundCheck : MonoBehaviour
{
    public GameObject Player;
    private PLAT_CharacterMovement playerMovScript;

    public bool isOnLand = false;

    private void Start()
    {
        playerMovScript = Player.GetComponent<PLAT_CharacterMovement>();
        //playerMovScript.Fall();
    }

    private void OnTriggerEnter(Collider other)
    {
        isOnLand = true;
        //playerMovScript.Land();
    }

    private void OnTriggerExit(Collider other)
    {
        isOnLand = false;
        //playerMovScript.Fall();
    }
}
