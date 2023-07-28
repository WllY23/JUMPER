using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour 
{
	public GameObject player;
	public GameObject win;
	public GameObject restart;

	void Update () 
	{
		if (player.transform.position.z >= 450) 
		{
			win.SetActive(true);
			restart.SetActive (true);
		}
	}

	public void Restart()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
