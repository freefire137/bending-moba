﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		bool RMB = Input.GetMouseButtonDown(1);
		if (RMB) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Ground") {		//TODO
				//this.GetComponent<PhotonView>().RPC("RecievedMove", PhotonTargets.All, hit.point);		move target using networking component
			}
		}


	}
}
