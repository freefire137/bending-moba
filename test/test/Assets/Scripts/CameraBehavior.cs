using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour {
	public float sensx = 10;
	public float sensy = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float mouseSpeedx = Input.GetAxis("Horizontal")*sensx;
		float mouseSpeedy = Input.GetAxis("Vertical")*sensy;
	}
}
