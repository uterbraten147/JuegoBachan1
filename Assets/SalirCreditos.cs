using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirCreditos : MonoBehaviour
{
    public float timer;
    public int Escena;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Timer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Timer()
    {

        while (true)
        {
            yield return new WaitForSeconds(timer);
            SceneManager.LoadScene(Escena);
        }
    }
}
