using UnityEngine;
using System.Collections;
using GameSchoolLibraries;

public class UpSpring : MonoBehaviour {
	public GameObject jumpSprite;
	public GameObject pinkCube;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnTriggerEnter2D(Collider2D thingIHit)
	{
		if(thingIHit.tag == "Crate")
		{
			thingIHit.gameObject.stopAllForces2D();
			thingIHit.gameObject.addForce2D(Vector2.up*500);
		}

	}
}
