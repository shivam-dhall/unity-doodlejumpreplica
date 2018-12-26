using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour {

	public GameObject platformPrefab;
	public GameObject jpp;
	public int nop = 100;
	public int nojp = 50;
	public float levelWidth = 2f;
	public float minY = 1.2f;
	public float maxY = 1.5f;

	// Use this for initialization
	void Start ()
	 {

		Vector3 spawnPosition = new Vector3();

		for (int j = 0; j < nojp; j++)
		{
			{
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth, levelWidth);
			Instantiate(jpp, spawnPosition, Quaternion.identity);
			
			}
				
				for (int i = 0; i < nop; i++)
					{
						spawnPosition.y += Random.Range(minY, maxY);
						spawnPosition.x = Random.Range(-levelWidth, levelWidth);
						Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
					}
		}
	}
}
