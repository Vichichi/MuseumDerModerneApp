using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ausblenden : MonoBehaviour
{
	public GameObject auszublenden;
	public float Sekunden;

	void Start()
	{
		StartCoroutine(fadeOut(Sekunden));
	}

	IEnumerator fadeOut(float WaitSecs)
    {
        yield return new WaitForSeconds(WaitSecs);
        auszublenden.SetActive(false);
    }
}
