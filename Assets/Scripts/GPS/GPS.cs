using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GPS : MonoBehaviour
{
    float latitude;
    float longitude;

    //MDM : the gedankenexperiment, Department of Water and Power, “Luminance of color…”, Kwiaty (Blumen)
    
    float Kunstwerk1lat = 47.80094f;
    float Kunstwerk1long = 13.03878f;

    public Text OutputText;
    public Text LocationText;
    public Text DistanceText;

    public GameObject popUpAnfang;
    public bool Bool1;

   // private int zuSzene1;
    //private int zuSzene2;


    //für den szenenwechsel
    public void SceneLoader(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TestLocation());

        //popUp deaktiviert
        popUpAnfang.gameObject.SetActive(false);
        Bool1 = false;
    }

    public void Update(){

        Distanz();
        StartCoroutine(TestLocation());
    }

    public void Distanz()
    {
        //sozusagen Delta x und Delta y
        float a = Kunstwerk1long- longitude;
        float b = Kunstwerk1lat - latitude;
    
        //Satz des Pythagoras 
        float c = a * a + b * b;

        //Wurzel aus Ergebnis von oben
        float d = Mathf.Sqrt(c);

        //abs, damit man kein nagatives Ergebnis bekommt
        float distanz = Mathf.Abs(d);

        // DistanceText.text = "Strecke bis zum Ziel: " + distanz;


        if (distanz < 0.004656978f)
        {
            Debug.Log("Hallo ich funktioniere");
            DistanceText.text = "350m";
        }
        if (distanz < 0.003909071f)
        {
            DistanceText.text = "300m";
        }
        if (distanz < 0.002666071f)
        {
            DistanceText.text = "200m";
        }

        if (distanz < 0.001328243f)
        {
            DistanceText.text = "100m";
        }

        if (distanz < 0.001057976f)
        {
            DistanceText.text = "80m";
        }

        if (distanz < 0.0006635057f)
        {
            DistanceText.text = "50m";
        }
        if (distanz < 0.0003919137f)
        {
            DistanceText.text = "30m";
        }
        if (distanz < 0.0002512855f)
        {
            DistanceText.text = "20m";
        }
        if (distanz < 0.0001216673)
        {
            DistanceText.text = "10m";
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
            popUpAnfang.gameObject.SetActive(false);
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


        //Zugriff und der Standortwert konnten abgerufen werden und dann passiert das da unten... 
        else
        {
            while (true)
            {

                //Position des Users (lat und long) wird vom system abgefragt und als float gespeichert
                latitude = Input.location.lastData.latitude;
                longitude = Input.location.lastData.longitude;

                LocationText.text = "Lat: " + latitude + "Long: " + longitude;
                yield return new WaitForSeconds(0);


                //popUp-Screen deaktiviert
                popUpAnfang.gameObject.SetActive(false);


                //MdM
                if (latitude < Kunstwerk1lat + 0.00005f && latitude > Kunstwerk1lat - 0.00005f && longitude < Kunstwerk1long + 0.0001f && longitude > Kunstwerk1long - 0.0001f)
                {
                    popUpAnfang.gameObject.SetActive(true);
                    Handheld.Vibrate();
                    Bool1 = true; 
                }
                else
                {
                    popUpAnfang.gameObject.SetActive(false);
                    Bool1 = false; 
                }

                
            }
        }


    }
}