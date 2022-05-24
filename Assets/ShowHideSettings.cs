using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHideSettings : MonoBehaviour
{
    public Button settingsButton;
    public GameObject settingsMenu;
    public void toggleMenu ()
    {
        if (settingsMenu.activeSelf == true)
        {
            settingsMenu.SetActive(false);
        }
        else if (settingsMenu.activeSelf == false)
        {
            settingsMenu.SetActive(true);
        }
    }
}
