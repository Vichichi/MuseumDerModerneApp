using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClickFunction : MonoBehaviour
{
    public Image popUpReminder;
    private RectTransform popUpReminderTransform;
    Collider med1col;
    public float smoothFactor = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        //Get the GameObjects Collider
        med1col = GetComponent<Collider>();
        //Stelle an Trigger auf False
        med1col.isTrigger = false;
        //Get Image Components
        popUpReminderTransform = popUpReminder.GetComponent<RectTransform>();
        //SAG WAS
        Debug.Log("ES GEHT WUWU Trigger is: " +med1col.isTrigger);
    }

    // Update is called once per frame
    void Update()
    {
        if(med1col.isTrigger == true)
        {
            popUpReminderTransform.anchoredPosition = new Vector3(0.38516f, -860.7f, 0f);

        }
    }

    void OnMouseDown()
    {
        //ANGEKLICKT
        med1col.isTrigger = true;
        //SAGS
        Debug.Log("HALLO ES GEHT JETZT IST ES: " +med1col.isTrigger);
    }
}
