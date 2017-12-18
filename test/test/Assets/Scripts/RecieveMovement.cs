using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class RecieveMovement : MonoBehaviour {

    Vector3 newPos;
    public float speed;
    public float walkRange;
    public GameObject graphics;

	// Use this for initialization
	void Start () {

        newPos = this.transform.position;       //on spawning

	}
	
	// Update is called once per frame
	void Update () {

        if (Vector3.Distance(newPos, this.transform.position) > walkRange) {
			this.transform.position = Vector3.MoveTowards(this.transform.position, newPos, speed * Time.deltaTime);
			Quaternion transRot = Quaternion.LookRotation(newPos - this.transform.position, Vector3.up);
			graphics.transform.rotation = Quaternion.Slerp(transRot, graphics.transform.rotation, 0.2F);
        }   
	}
			//TODO
	/*			put networking stuff here		
	[PunRPC]
	public void RecievedMove(Vector3 movePos) {
		newPos = movePos;
	}
	*/
}
