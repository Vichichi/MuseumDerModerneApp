using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClickFunction : MonoBehaviour
{
    //I hol ma de Ui-Images
    public RectTransform popUpReminderTransform;
    public RectTransform popUpReminderTransform2;
    public RectTransform popUpReminderTransform3;
    public RectTransform popUpReminderTransform4;
    public RectTransform popUpReminderTransform5;
    public RectTransform popUpReminderTransform6;
    public RectTransform popUpReminderTransform7;

    //------------------------------------------------------------------------------------------------------------//   

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Gurken")
            {
                ResetImages();

                popUpReminderTransform.anchoredPosition = new Vector3(0.38516f, -815.93f, 0f);
            }
            
            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Bestiarium")
            {
                ResetImages();

                popUpReminderTransform2.anchoredPosition = new Vector3(0.38516f, -815.93f, 0f);
            }
           
            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "AEIOU")
            {
                Debug.Log("AEIOU");
                ResetImages();

                popUpReminderTransform3.anchoredPosition = new Vector3(0.38516f, -815.93f, 0f);
            }

            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Zungebaerte")
            {
                ResetImages();

                popUpReminderTransform4.anchoredPosition = new Vector3(0.38516f, -815.93f, 0f);
            }

              if (Physics.Raycast(ray, out hit) && hit.transform.tag == "EingangMdM")
            {
                ResetImages();

                popUpReminderTransform5.anchoredPosition = new Vector3(0.38516f, -815.93f, 0f);
            }

              if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Drugs")
            {
                ResetImages();
                popUpReminderTransform6.anchoredPosition = new Vector3(0.38516f, -815.93f, 0f);
            }

              if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Haus")
            {
                ResetImages();

                popUpReminderTransform7.anchoredPosition = new Vector3(0.38516f, -815.93f, 0f);
            }
        }
    }

    void ResetImages()
    {
        popUpReminderTransform.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
        popUpReminderTransform2.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
        popUpReminderTransform3.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
        popUpReminderTransform4.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
        popUpReminderTransform5.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
        popUpReminderTransform6.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
        popUpReminderTransform7.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
    }
}
