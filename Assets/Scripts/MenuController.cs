using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject MainPanel, PlayPanel, CreditsPanel, OpcionesPanel;
    public GameObject Cam;
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


    }

    public void PlayAjustesMenu()
    {
        MainPanel.SetActive(false);
        PlayPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        OpcionesPanel.SetActive(true);


    }

    public void PlayCreditosMenu()
    {
        MainPanel.SetActive(false);
        PlayPanel.SetActive(false);
        CreditsPanel.SetActive(true);
        OpcionesPanel.SetActive(false);


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


    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}



