using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class kunstwerk9 : MonoBehaviour
{
    //AEIOU

    float latitude;
    float longitude;

    float Kunstwerk9lat = 47.949811f;
    float Kunstwerk9long = 12.676432f;

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
        float a = Kunstwerk9long - longitude;
        float b = Kunstwerk9lat - latitude;

        //Satz des Pythagoras 
        float c = a * a + b * b;

        //Wurzel aus Ergebnis von oben
        float d = Mathf.Sqrt(c);

        //abs, damit man kein nagatives Ergebnis bekommt
        float distanz = Mathf.Abs(d);

        // DistanceText.text = "Strecke bis zum Ziel: " + distanz;

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
                if (latitude < Kunstwerk9lat + 0.00007f && latitude > Kunstwerk9lat - 0.00007f && longitude < Kunstwerk9long + 0.00007f && longitude > Kunstwerk9long - 0.00007f)
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

