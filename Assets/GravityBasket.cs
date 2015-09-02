using UnityEngine;
using System.Collections;
using GameSchoolLibraries;

public class GravityBasket : MonoBehaviour {
	public GameObject pinkCube;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		pinkCube.stopAllForces2D();
		//turn off gravity for object coming in
		//give upward force for  object coming in. 
	
	}
}
