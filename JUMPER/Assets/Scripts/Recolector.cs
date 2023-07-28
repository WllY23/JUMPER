using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recolector : MonoBehaviour 
{
	public Text countTextDiamond;
	private int countDiamond;

	void Start ()
	{
		countDiamond = 0;
		SetCountText ();
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Diamante1"))
		{
			other.gameObject.SetActive (false);
			countDiamond += 10;
			SetCountText ();
		}
		if (other.gameObject.CompareTag ("Diamante2")) 
		{
			other.gameObject.SetActive (false);
			countDiamond += 20;
			SetCountText ();
		}
		if (other.gameObject.CompareTag ("Diamante3")) 
		{
			other.gameObject.SetActive (false);
			countDiamond += 30;
			SetCountText ();
		}
	}

	public void SetCountText ()
	{
		countTextDiamond.text = "Diamonds: " + countDiamond.ToString ();
	}
}
