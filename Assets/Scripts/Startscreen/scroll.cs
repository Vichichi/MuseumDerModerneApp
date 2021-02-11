using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
	public GameObject Infomodus;
	public GameObject Spielemodus;

   public void Informationsmodus()
   {
		  Infomodus.SetActive(true);
		  Spielemodus.SetActive(false);
   }

   public void Spieli()
   {
		  Spielemodus.SetActive(true);
		  Infomodus.SetActive(false);
   }
}
