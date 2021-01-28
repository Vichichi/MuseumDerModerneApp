using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoHintergrundQuerBild : MonoBehaviour
{
    public GameObject Background;
    public GameObject BackgroundOpen;
    public GameObject Textfeld;
    public GameObject ButtonOpen;
    public GameObject ButtonClose;

    public void OpenBackground()
    {
        BackgroundOpen.SetActive(true);
        Background.SetActive(false);
        Textfeld.SetActive(false);
        ButtonOpen.SetActive(false);
        ButtonClose.SetActive(true);
    }

    public void CloseBackground()
    {
        BackgroundOpen.SetActive(false);
        Background.SetActive(true);
        Textfeld.SetActive(true);
        ButtonOpen.SetActive(true);
        ButtonClose.SetActive(false);
    }

}
