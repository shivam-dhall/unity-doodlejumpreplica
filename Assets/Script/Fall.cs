using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour {

	public Transform camm;

	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < (camm.transform.position.y - 5f))
		{
			transform.position = new Vector3(-0.053f,-1.247f,0);
			camm.transform.position = new Vector3 (0,0,-10f);
		}
	}
}
