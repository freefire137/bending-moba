using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	
	//public GameObject BendingObj;
	public Transform CameraTransform;
	private int movespeed;
	private Vector3 localpos;
	private Vector3 worldpos;
	private Quaternion cameraRotation;
	public enum bendingStyle : int {none, water, earth, fire, air};
	private bendingStyle bending;
	void Start () {
		CameraTransform = transform.GetChild(1);
		//bending = gameObject.GetComponent<>
	}
	
	void Update () {
		movespeed = gameObject.GetComponent<Waterbender>().SpeedStat;
		worldpos = transform.position;
		cameraRotation = CameraTransform.rotation;
		if (Input.GetButton("Up"))
			worldpos = worldpos + (Vector3.forward*movespeed);
		if (Input.GetButton("Down"))
			worldpos = worldpos + (Vector3.back*movespeed);
		if (Input.GetButton("Left"))
			worldpos = worldpos + (Vector3.left*movespeed);		
		if (Input.GetButton("Right"))
			worldpos = worldpos + (Vector3.right*movespeed);	
	}
}
