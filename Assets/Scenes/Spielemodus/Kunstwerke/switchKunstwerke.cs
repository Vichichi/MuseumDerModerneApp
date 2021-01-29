using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchKunstwerke : MonoBehaviour
{
   public void MdmOben()
    {
        UnityEngine.Debug.Log("MdmOben");
        Application.LoadLevel(37);
    }

    public void InAndOut()
    {
        UnityEngine.Debug.Log("Eine und ause");
        Application.LoadLevel(38);
    }

    public void Drugsi()
    {
        UnityEngine.Debug.Log("LSD");
        Application.LoadLevel(39);
    }
}
