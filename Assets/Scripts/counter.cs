using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counter : MonoBehaviour
{
    public int kunstwerke = 0;

    public void ChangeKunstwerk()
    {      
        if(kunstwerke == 0)
        {  
            Application.LoadLevel(54);
        }

        if(kunstwerke == 1)
        {
            Application.LoadLevel(56);
        }

        if(kunstwerke == 2)
        {
            Application.LoadLevel(57);
        }

        if(kunstwerke == 3)
        {
            Application.LoadLevel(58);
        }

        if(kunstwerke == 4)
        {
            Application.LoadLevel(59);
        }

        if(kunstwerke == 5)
        {
            Application.LoadLevel(60);
        }

        if(kunstwerke == 6)
        {
            Application.LoadLevel(61);
        }

        if(kunstwerke == 7)
        {
            Application.LoadLevel(62);
        }

        if(kunstwerke == 8)
        {
            Application.LoadLevel(63);
        }

        if(kunstwerke == 9)
        {
            Application.LoadLevel(64);
        }

        if(kunstwerke == 10)
        {
            Application.LoadLevel(65);
        }
    }
}
