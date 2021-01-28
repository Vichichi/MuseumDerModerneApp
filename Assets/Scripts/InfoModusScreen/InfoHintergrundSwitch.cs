using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoHintergrundSwitch : MonoBehaviour
{
    public GameObject Textfeld;
    public GameObject ButtonOpen;
    public GameObject ButtonClose;

    public void OpenBackground()
    {
        Textfeld.SetActive(false);
        ButtonOpen.SetActive(false);
        ButtonClose.SetActive(true);
    }

    public void CloseBackground()
    {
        Textfeld.SetActive(true);
        ButtonOpen.SetActive(true);
        ButtonClose.SetActive(false);
    }

}
