using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        //Load a scene by the name "SceneName" if you press the W key.
        if (Input.anyKey || Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
