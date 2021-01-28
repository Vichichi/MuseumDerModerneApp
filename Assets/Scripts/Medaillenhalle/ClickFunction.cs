using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClickFunction : MonoBehaviour
{
    //I hol ma de Ui-Images
    public Image popUpReminder;
    public Image popUpReminder2;
    public Image popUpReminder3;
    public Image popUpReminder4;
    public Image popUpReminder5;
    public Image popUpReminder6;
    public Image popUpReminder7;

    private RectTransform popUpReminderTransform;
    private RectTransform popUpReminderTransform2;
    private RectTransform popUpReminderTransform3;
    private RectTransform popUpReminderTransform4;
    private RectTransform popUpReminderTransform5;
    private RectTransform popUpReminderTransform6;
    private RectTransform popUpReminderTransform7;

    Vector3[] Ohne1;


    //------------------------------------------------------------------------------------------------------------//   
    // Start is called before the first frame update
    void Start()
    {
        //Get Image Components
        popUpReminderTransform = popUpReminder.GetComponent<RectTransform>();
        popUpReminderTransform2 = popUpReminder2.GetComponent<RectTransform>();
        popUpReminderTransform3 = popUpReminder3.GetComponent<RectTransform>();
        popUpReminderTransform4 = popUpReminder3.GetComponent<RectTransform>();
        popUpReminderTransform5 = popUpReminder3.GetComponent<RectTransform>();
        popUpReminderTransform6 = popUpReminder3.GetComponent<RectTransform>();
        popUpReminderTransform7 = popUpReminder3.GetComponent<RectTransform>();
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Gurken")
            {
                popUpReminderTransform.anchoredPosition = new Vector3(0.38516f, -815.93f, 0f);

                popUpReminderTransform2.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform3.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform4.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform5.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform6.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform7.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
            }
            
            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Bestiarium")
            {
                popUpReminderTransform2.anchoredPosition = new Vector3(0.38516f, -815.93f, 0f);

                popUpReminderTransform.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform3.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform4.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform5.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform6.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform7.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
            }
           
            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "AEIOU")
            {
                Debug.Log("AEIOU");
                popUpReminderTransform3.anchoredPosition = new Vector3(0.38516f, -815.93f, 0f);

                popUpReminderTransform.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform2.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform4.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform5.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform6.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform7.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
            }

              if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Zungenbaerte")
            {
                popUpReminderTransform4.anchoredPosition = new Vector3(0.38516f, -815.93f, 0f);

                popUpReminderTransform.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform2.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform3.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform5.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform6.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform7.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
            }

              if (Physics.Raycast(ray, out hit) && hit.transform.tag == "EingangMdM")
            {
                popUpReminderTransform5.anchoredPosition = new Vector3(0.38516f, -815.93f, 0f);

                popUpReminderTransform.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform2.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform3.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform4.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform6.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform7.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
            }

              if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Drugs")
            {
                popUpReminderTransform6.anchoredPosition = new Vector3(0.38516f, -815.93f, 0f);

                popUpReminderTransform.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform2.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform3.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform4.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform5.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform7.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
            }

              if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Haus")
            {
                popUpReminderTransform7.anchoredPosition = new Vector3(0.38516f, -815.93f, 0f);

                popUpReminderTransform.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform2.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform3.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform4.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform5.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
                popUpReminderTransform6.anchoredPosition = new Vector3(0.38516f, -1103.399f, 0f);
            }
        }
    }
}
