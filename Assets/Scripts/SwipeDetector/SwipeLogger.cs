using UnityEngine;

public class SwipeLogger : MonoBehaviour
{
    public GameObject Medaillen;

    private void Awake()
    {
        SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
    }

    private void SwipeDetector_OnSwipe(SwipeData data)
    { 
        Debug.Log("Swipe in Direction: " + data.Direction);
        
        if (data.Direction.ToString() == "Left")
        {
          Medaillen.transform.Rotate(0,90,0, Space.Self);
        } 

        if (data.Direction.ToString() == "Right")
        {
          Medaillen.transform.Rotate(0,-90,0, Space.Self);
        }
    }
}