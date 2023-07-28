using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesManager : MonoBehaviour 
{
	public GameObject[] tilePrefabs;
	private Transform playerTransform;
	private float spawnZ = 12.0f;
	private float tileLeght = 30.0f;
	private int tilesOnScreen = 3;
	private float safeZone = 20f;
	private int lastPrefabIndex = 0;
	private List<GameObject> activeTiles;

	void Start () 
	{
		activeTiles = new List<GameObject> ();
		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;	
		for (int i = 0; i < tilesOnScreen; i++) 
		{
			if (i<2) 
				SpawnTile (0);
			else 
				SpawnTile ();
		}
	}
	
	void Update () 
	{
		if (playerTransform.position.z - safeZone > (spawnZ - tilesOnScreen * tileLeght)) 
		{
			SpawnTile ();
			Deletetile ();
		}
	}

	private void SpawnTile(int prefabIndex = -1)
	{
		GameObject go;
		if (prefabIndex == -1)
			go = Instantiate (tilePrefabs [RandomPrefabIndex ()]) as GameObject;
		else
			go = Instantiate (tilePrefabs [prefabIndex]) as GameObject;
		go.transform.SetParent (transform);
		go.transform.position = Vector3.forward * spawnZ;
		spawnZ += tileLeght;
		activeTiles.Add (go);
	}

	private void Deletetile () 
	{
		Destroy (activeTiles [0]);
		activeTiles.RemoveAt (0);
	}

	private int RandomPrefabIndex()
	{
		if (tilePrefabs.Length <=1) 
			return 0;
			int randmIndex = lastPrefabIndex;
			while (randmIndex == lastPrefabIndex) 
			{
				randmIndex = Random.Range (0, tilePrefabs.Length);
			}
			lastPrefabIndex = randmIndex;
			return randmIndex;
	}
}
