using UnityEngine;
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

	void OnTriggerEnter2D(Collider2D col)
	{
		beamSystem.isEnabled(true);
	}

	void OnTriggerExit2D(Collider2D col)
	{
		beamSystem.isEnabled(false);
	}
}
