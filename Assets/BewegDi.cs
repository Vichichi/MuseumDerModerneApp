using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchEingabe : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch Beruehrung = Input.GetTouch(0);
            Vector3 BeruehrungsPosition = Camera.main.ScreenToWorldPoint(Beruehrung.position);
            BeruehrungsPosition.z = 0f;
            transform.position = BeruehrungsPosition;
        }
    }
}
