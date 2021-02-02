using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadIntro : MonoBehaviour
{
    
    public Image mdmLogo;
    public float fadeSpeed;
   
    void Start()
    {
        StartCoroutine(loadScene(5));
        StartCoroutine(FadeInObject());
    }

    IEnumerator loadScene(float WaitSecs)
    {
        yield return new WaitForSeconds(WaitSecs);
        Application.LoadLevel(1);
    }

    public IEnumerator FadeInObject()
    {
        Debug.Log("FADE");
        while (mdmLogo.GetComponent<Image>().color.a < 255) //es geht nur wenns alpha kleiner als 1 ist
        {
            Color objectColor = mdmLogo.GetComponent<Image>().color; //die color aus dem gameobject nehmen
            float fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);  //die transition

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount); //neue Color setzten
            mdmLogo.GetComponent<Image>().color = objectColor; 
            yield return null;
        }
    }

}
