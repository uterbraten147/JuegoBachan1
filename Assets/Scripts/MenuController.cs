using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject MainPanel, PlayPanel, CreditsPanel, OpcionesPanel;
    public GameObject Cam, firstMain, firstPlay, firstCred, firstOP;
    float giro;
    void Start()
    {
        MainPanel.SetActive(true);
        PlayPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        OpcionesPanel.SetActive(false);
        print(PlayPanel.activeSelf);

        
    }

    // Update is called once per frame
    void Update()
    {


        Cam.transform.Rotate(0, 0.1f, 0);
        
    }

  
    public void PlayPanelMenu()
    {
        MainPanel.SetActive(false);
        PlayPanel.SetActive(true);
        CreditsPanel.SetActive(false);
        OpcionesPanel.SetActive(false);

        GameObject.Find("EventSystem").GetComponent<EventSystem>().SetSelectedGameObject(firstPlay,null);


    }

    public void PlayAjustesMenu()
    {
        MainPanel.SetActive(false);
        PlayPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        OpcionesPanel.SetActive(true);

        GameObject.Find("EventSystem").GetComponent<EventSystem>().SetSelectedGameObject(firstOP, null);


    }

    public void PlayCreditosMenu()
    {
        MainPanel.SetActive(false);
        PlayPanel.SetActive(false);
        CreditsPanel.SetActive(true);
        OpcionesPanel.SetActive(false);
        GameObject.Find("EventSystem").GetComponent<EventSystem>().SetSelectedGameObject(firstCred, null);


    }

    public void SalirJuego()
    {

        Application.Quit();

    }

    public void RegresarMenuPrincipal()
    {
        MainPanel.SetActive(true);
        PlayPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        OpcionesPanel.SetActive(false);
        GameObject.Find("EventSystem").GetComponent<EventSystem>().SetSelectedGameObject(firstMain, null);


    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}



