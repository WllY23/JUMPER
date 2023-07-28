using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour 
{
	private Transform target;
	private Vector3 offSet;
	private Vector3 moveVector;

	void Start () 
	{
		target =	GameObject.FindGameObjectWithTag ("Player").transform;
		offSet = transform.position - target.position;
	}
	
	void Update () 
	{
		moveVector = target.position + offSet;
		moveVector.x = 0;
		moveVector.y = 2.73f;
		transform.position = moveVector;
	}
}
