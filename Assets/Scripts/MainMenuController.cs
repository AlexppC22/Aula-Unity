using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] GameObject mainMenuCanvas;
    [SerializeField] GameObject creditsCanvas;
    [SerializeField] GameObject settingsCanvas;

    public AudioSource interfaceSFX;
    public void GoToMenuButton(int index)
    {
        mainMenuCanvas.SetActive(false);
        creditsCanvas.SetActive(false);
        interfaceSFX.Play();
        switch (index)
        {
            case 0:
                mainMenuCanvas.SetActive(true);
                break;
            case 1:
                creditsCanvas.SetActive(true);
                break;
        }
    }
}
