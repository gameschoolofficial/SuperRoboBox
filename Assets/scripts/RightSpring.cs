using UnityEngine;
using System.Collections;
using GameSchoolLibraries;
public class RightSpring : MonoBehaviour {
	public GameObject jumpsprite;
	public GameObject pinkcube;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	void OnTriggerEnter2D(Collider2D thingIHit)
	{
		if (thingIHit.tag == "Crate") 
		{
			thingIHit.gameObject.addForce2D (Vector2.right * 150);
		}
	}
}