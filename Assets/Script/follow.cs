using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

	public Transform player;
	public float sspeed= 0.3f;
	private Vector3 cV;
	void LateUpdate () {
		if (player.position.y > transform.position.y)
		{
			Vector3 newPos = new Vector3(transform.position.x, player.position.y, transform.position.z);
			transform.position = Vector3.SmoothDamp(transform.position,newPos, ref cV,sspeed*Time.deltaTime);
		}
		//else
		//{
		//	transform.position=cam.position;
		//}
	}
}
