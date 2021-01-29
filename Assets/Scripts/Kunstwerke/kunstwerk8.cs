﻿using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class kunstwerk8 : MonoBehaviour
{
    //Gurken

    float latitude;
    float longitude;

    float Kunstwerk8lat = 47.949794f;
    float Kunstwerk8long = 12.676588f;

    public GameObject PopUp;

    public Text OutputText;
    public Text DistanceText;
    public Text LocationText;


    public void SceneLoader(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }


    void Start()
    {
        // StartCoroutine(TestLocation());

        //popUp deaktiviert
        PopUp.gameObject.SetActive(false);
    }


    public void Update()
    {
        Distanz();
        StartCoroutine(TestLocation());
    }


    public void Distanz()
    {
        //sozusagen Delta x und Delta y
        float a = Kunstwerk8long - longitude;
        float b = Kunstwerk8lat - latitude;

        //Satz des Pythagoras 
        float c = a * a + b * b;

        //Wurzel aus Ergebnis von oben
        float d = Mathf.Sqrt(c);

        //abs, damit man kein nagatives Ergebnis bekommt
        float distanz = Mathf.Abs(d);

        // DistanceText.text = "Strecke bis zum Ziel: " + distanz;
        if (distanz < 0.004656978f)
        {
            DistanceText.text = "350m to the artwork";
        }
        if (distanz < 0.003909071f)
        {
            DistanceText.text = "300m to the artwork";
        }
        if (distanz < 0.003303639f)
        {
            DistanceText.text = "250m to the artwork";
        }
        if (distanz < 0.002666071f)
        {
            DistanceText.text = "200m to the artwork";
        }
        if (distanz < 0.001990914f)
        {
            DistanceText.text = "150m to the artwork";
        }
        if (distanz < 0.001591255f)
        {
            DistanceText.text = "120m to the artwork";
        }
        if (distanz < 0.001328243f)
        {
            DistanceText.text = "100m to the artwork";
        }
        if (distanz < 0.001057976f)
        {
            DistanceText.text = "80m to the artwork";
        }
        if (distanz < 0.0006635057f)
        {
            DistanceText.text = "50m to the artwork";
        }
        if (distanz < 0.0002512855f)
        {
            DistanceText.text = "20m to the artwork";
        }
        if (distanz < 0.0001822117f)
        {
            DistanceText.text = "15m to the artwork";
        }
        if (distanz < 0.0001216673)
        {
            DistanceText.text = "10m to the artwork";
        }

    }


    IEnumerator TestLocation()
    {
        // First, check if user has location service enabled
        while (!Input.location.isEnabledByUser)
        {
            OutputText.text = "Tracking is Disabled!";

            yield return new WaitForSeconds(10);

            //popUp deaktiviert
            PopUp.gameObject.SetActive(false);
        }

        Input.location.Start(10, 10);


        // Warten, bis der Service angeschalten wird
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        //Service didn't initialize in 20 seconds
        if (maxWait < 1)
        {
            OutputText.text = "Time out";
            yield break;
        }

        // Connection has failed
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            OutputText.text = "Nein";
            yield break;
        }

        else
        {
            while (true)
            {

                //Position des Users (lat und long) wird vom system abgefragt und als float gespeichert
                latitude = Input.location.lastData.latitude;
                longitude = Input.location.lastData.longitude;

                LocationText.text = "Lat: " + latitude + "Long: " + longitude;
                yield return new WaitForSeconds(0);

                //MdM
                if (latitude < Kunstwerk8lat + 0.00007f && latitude > Kunstwerk8lat - 0.00007f && longitude < Kunstwerk8long + 0.00007f && longitude > Kunstwerk8long - 0.00007f)
                {
                    PopUp.gameObject.SetActive(true);
                    Handheld.Vibrate();
                } 
                else
                {
                    OutputText.text = "Keep searching!";
                    PopUp.gameObject.SetActive(false);
                }
            }

        }
    }
}

