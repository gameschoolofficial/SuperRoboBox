﻿using UnityEngine;
using System.Collections;
using GameSchoolLibraries;

public class GravityButton : MonoBehaviour {

	public GameObject beamSystem;

	// Use this for initialization
	void Start () {
		beamSystem.isEnabled(false);
	

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//when player enters this box, turn on beam system


	//when player leaves this box, turn off beam system


}
