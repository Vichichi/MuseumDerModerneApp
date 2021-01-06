using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fade : MonoBehaviour
{
        public Image FadeObject;
        public float fadeSpeed;
   
        void Start()
        {
            StartCoroutine(FadeInObject());
        }

        public IEnumerator FadeInObject()
        {
            Debug.Log("FADE");
            while (FadeObject.GetComponent<Image>().color.a < 255) //es geht nur wenns alpha kleiner als 1 ist
            {
                Color objectColor = FadeObject.GetComponent<Image>().color; //die color aus dem gameobject nehmen
                float fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);  //die transition

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount); //neue Color setzten
                FadeObject.GetComponent<Image>().color = objectColor; 
                yield return null;
            }
        }
}
