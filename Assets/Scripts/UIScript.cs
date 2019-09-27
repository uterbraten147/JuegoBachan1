using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIScript : MonoBehaviour
{
    public Text GameOverText;
    public Image winImage;
    public Image LoseImage;

    public GameObject GameOverPanel;

    public bool WinBool= false;
    public bool GameOver = false;
    // Start is called before the first frame update
    void Start()
    {

        winImage.enabled = false;
        LoseImage.enabled = false;
        GameOverPanel.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver)
        {
            GameOverPanel.SetActive(true);
            if (WinBool)
            {
                GameOverText.text = "Omedeto jugador-kun";
                winImage.enabled = true;

            }
            else
            {
                GameOverText.text = "You fucking donkey";
                LoseImage.enabled = true;
            }
        }
            
        
    }
}
