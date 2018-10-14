using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterbender : MonoBehaviour {
	public enum bendingStyle : int {none, water, earth, fire, air};
	public bendingStyle BendingAbility = (bendingStyle)1;
	public int SpeedStat = 1;
	
	// Use this for initialization
	void Start () {
		
	}

	public int getSpeedStat(){
		return SpeedStat;
	}
	
	public bendingStyle GetBendingStyle(){
		return BendingAbility;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
