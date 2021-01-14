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
    public float Kunstwerk1lat;
    float Kunstwerk1long;

    //Eingang MönchsbergAufzug Talstation,
    float Kunstwerk2lat;
    float Kunstwerk2long;

    // Schlafendes Haus
    float Kunstwerk3lat;
    float Kunstwerk3long;

    //Sky Space
    float Kunstwerk4lat;
    float Kunstwerk4long;

    //inside of & outside of itself
    float Kunstwerk5lat;
    float Kunstwerk5long;

    //Drugs / Liquor
    float Kunstwerk6lat;
    float Kunstwerk6long;

    //Ziffern im Wald
    float Kunstwerk7lat;
    float Kunstwerk7long;

    //Zungenbärte
    float Kunstwerk8lat;
    float Kunstwerk8long;

    //Bestiarium
    float Kunstwerk9lat;
    float Kunstwerk9long;

    //Gurken
    float Kunstwerk10lat;
    float Kunstwerk10long;

    //A.E.I.O.U., 
    float Kunstwerk11lat;
    float Kunstwerk11long;


    public Text OutputText;
    public Text LocationText;

    public GameObject popUpAnfang;

    private int zuSzene1;
    private int zuSzene2;


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


                //MdM
                Kunstwerk1lat = 47.800942f;
                Kunstwerk1long = 13.038788f;

                //Eingang MönchsbergAufzug Talstation
                Kunstwerk2lat = 47.800863f; 
                Kunstwerk2long = 13.039024f;

                //Schlafendes Haus
                Kunstwerk3lat = 47.800543f; 
                Kunstwerk3long = 13.038422f;

                //Sky Space
                Kunstwerk4lat = 47.800526f; 
                Kunstwerk4long = 13.038494f;

                //inside of & outside of itself
                Kunstwerk5lat = 47.800705f; 
                Kunstwerk5long = 13.038712f;

                //Drugs / Liquor
                Kunstwerk6lat = 47.800748f;
                Kunstwerk6long = 13.038500f;

                //Ziffern im Wald
                Kunstwerk7lat = 47.801655f;
                Kunstwerk7long = 13.038249f;

                //Zungenbärte
                Kunstwerk8lat = 47.798261f; 
                Kunstwerk8long = 13.043276f;

                //Bestiarium
                Kunstwerk9lat = 47.798242f;
                Kunstwerk9long = 13.043422f;

                //Gurken
                Kunstwerk10lat = 47.798772f; 
                Kunstwerk10long = 13.042294f;

                //A.E.I.O.U.
                Kunstwerk11lat = 47.798541f; 
                Kunstwerk11long = 13.042785f;


                //popUp-Screen deaktiviert
                popUpAnfang.gameObject.SetActive(false);


                //MdM
                if (latitude < Kunstwerk1lat + 0.00005f && latitude > Kunstwerk1lat - 0.00005f && longitude < Kunstwerk1long + 0.0001f && longitude > Kunstwerk1long - 0.0001f)
                {
                    popUpAnfang.gameObject.SetActive(true);
                    Handheld.Vibrate();
                }
                else
                {
                    OutputText.text = "Keep searching!";
                    popUpAnfang.gameObject.SetActive(false);
                }

                //Eingang
                if (latitude < Kunstwerk2lat + 0.00008f && latitude > Kunstwerk2lat - 0.00008f && longitude < Kunstwerk2long + 0.00008f && longitude > Kunstwerk2long - 0.00008f)
                {
                    popUpAnfang.gameObject.SetActive(true);
                }
                else 
                {
                    OutputText.text = "Keep searching!";
                    popUpAnfang.gameObject.SetActive(false);
                }

                //Schlafendes Haus
                if (latitude < Kunstwerk3lat + 0.00008f && latitude > Kunstwerk3lat - 0.00008f && longitude < Kunstwerk3long + 0.00008f && longitude > Kunstwerk3long - 0.00008f)
                {
                    popUpAnfang.gameObject.SetActive(true);
                }
                else
                {
                    OutputText.text = "Keep searching!";
                    popUpAnfang.gameObject.SetActive(false);
                }

                //Sky
                if (latitude < Kunstwerk4lat + 0.00008f && latitude > Kunstwerk4lat - 0.00008f && longitude < Kunstwerk4long + 0.00008f && longitude > Kunstwerk4long - 0.00008f)
                {
                    popUpAnfang.gameObject.SetActive(true);
                }
                else
                {
                    OutputText.text = "Keep searching!";
                    popUpAnfang.gameObject.SetActive(false);
                }

                //inside&outside
                if (latitude < Kunstwerk5lat + 0.0001f && latitude > Kunstwerk5lat - 0.0001f && longitude < Kunstwerk5long + 0.0001f && longitude > Kunstwerk5long - 0.0001f)
                {
                    popUpAnfang.gameObject.SetActive(true);
                }
                else
                {
                    OutputText.text = "Keep searching!";
                    popUpAnfang.gameObject.SetActive(false);
                }

                //drugs&liquor
                if (latitude < Kunstwerk6lat + 0.00002f && latitude > Kunstwerk6lat - 0.00002f && longitude < Kunstwerk6long + 0.00002f && longitude > Kunstwerk6long - 0.00002f)
                {
                    popUpAnfang.gameObject.SetActive(true);
                }
                else
                {
                    OutputText.text = "Keep searching!";
                    popUpAnfang.gameObject.SetActive(false);
                }

                //Ziffern im Wald
                if (latitude < Kunstwerk7lat + 0.00002f && latitude > Kunstwerk7lat - 0.00002f && longitude < Kunstwerk7long + 0.00002f && longitude > Kunstwerk7long - 0.00002f)
                {
                    popUpAnfang.gameObject.SetActive(true);
                }
                else
                {
                    OutputText.text = "Keep searching!";
                    popUpAnfang.gameObject.SetActive(false);
                }

                //Zungenbärte
                if (latitude < Kunstwerk8lat + 0.0001f && latitude > Kunstwerk8lat - 0.0001f && longitude < Kunstwerk8long + 0.0001f && longitude > Kunstwerk8long - 0.0001f)
                {
                    popUpAnfang.gameObject.SetActive(true);
                }
                else
                {
                    OutputText.text = "Keep searching!";
                    popUpAnfang.gameObject.SetActive(false);
                }

                //Bestarium
                if (latitude < Kunstwerk9lat + 0.00009f && latitude > Kunstwerk9lat - 0.00009f && longitude < Kunstwerk9long + 0.00009f && longitude > Kunstwerk9long - 0.00009f)
                {
                    popUpAnfang.gameObject.SetActive(true);
                }
                else
                {
                    OutputText.text = "Keep searching!";
                    popUpAnfang.gameObject.SetActive(false);
                }

                //Gurken
                if (latitude < Kunstwerk10lat + 0.0001f && latitude > Kunstwerk10lat - 0.0001f && longitude < Kunstwerk10long + 0.0001f && longitude > Kunstwerk10long - 0.0001f)
                {
                    popUpAnfang.gameObject.SetActive(true);
                }
                else
                {
                    OutputText.text = "Keep searching!";
                    popUpAnfang.gameObject.SetActive(false);
                }

                //AEIOU
                if (latitude < Kunstwerk11lat + 0.00004f && latitude > Kunstwerk11lat - 0.00004f && longitude < Kunstwerk11long + 0.0001f && longitude > Kunstwerk11long - 0.0001f)
                {
                    popUpAnfang.gameObject.SetActive(true);
                }
                else
                {
                    OutputText.text = "Keep searching!";
                    popUpAnfang.gameObject.SetActive(false);
                }

            }
        }


    }
}