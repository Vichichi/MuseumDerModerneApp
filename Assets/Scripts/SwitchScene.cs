using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class SwitchScene : MonoBehaviour
{
    public void InfoSpieleScreen()
    {
        UnityEngine.Debug.Log("Spiele und Info Auswahl dingens");
        Application.LoadLevel(1);
    }

    public void Infomodus()
    {
        UnityEngine.Debug.Log("iwillnimma");
        Application.LoadLevel(2);
    }

    public void Location()
    {
        UnityEngine.Debug.Log("iwillnoimmaned");
        Application.LoadLevel(3);
    }

    public void Hilfemodus()
    {
        UnityEngine.Debug.Log("Hilfemodus");
        Application.LoadLevel(4);
    }

    public void BildInfoInformationsModus()
    {
        UnityEngine.Debug.Log("BildInformationImInformationsmodus");
        Application.LoadLevel(5);
    }

    public void Erklaerscreen()
    {
        UnityEngine.Debug.Log("blablabla");
        Application.LoadLevel(6);
    }

    public void Spielmodus()
    {
        UnityEngine.Debug.Log("Spielemodus");
        Application.LoadLevel(7);
    }

    public void Spielemodus2()
    {
        UnityEngine.Debug.Log("Spielemodus2");
        Application.LoadLevel(8);
    }

    public void Medaillenhalle()
    {
        UnityEngine.Debug.Log("Medaillen");
        Application.LoadLevel(9);
    }

    public void HilfeSpiele()
    {
        UnityEngine.Debug.Log("Hilfe für die Spiele");
        Application.LoadLevel(10);
    }

    public void Minigames()
    {
        UnityEngine.Debug.Log("Minigames owo");
        Application.LoadLevel(11);
    }

    public void Gurken()
    {
        UnityEngine.Debug.Log("Die Gurken sind da");
        Application.LoadLevel(12);
    }
}
