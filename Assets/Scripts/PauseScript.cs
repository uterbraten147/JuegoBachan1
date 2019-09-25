using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject panelPausa;
    bool IsPaused= false;
    float CurrentTimeScale = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        panelPausa.SetActive(false);
        bool IsPaused = false;
        float CurrentTimeScale = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Button_Back") || Input.GetKeyDown(KeyCode.Escape))
        {
            if(!IsPaused)
            {
                IsPaused = true;
                CurrentTimeScale = Time.timeScale;
                Time.timeScale = 0;
                panelPausa.SetActive(true);
                Cursor.visible = true;

            }
            else
            {
                Time.timeScale = CurrentTimeScale;
                IsPaused = false;
                panelPausa.SetActive(false);
                Cursor.visible = false;
            }
        }

      
        
    }
    public void ResumeGame()
    {
        Time.timeScale = CurrentTimeScale;
        IsPaused = false;
        panelPausa.SetActive(false);
        Cursor.visible = false;

    }

    public void ExitGame()
    {
        SceneManager.LoadScene(0);
    }

}
