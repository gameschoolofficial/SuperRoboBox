using UnityEngine;
using System.Collections;

public class testFunctions : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyUp(KeyCode.F))
		{
//			if(this.GetComponent<Rigidbody>() == null)
//				Debug.LogError('You need to add a rigidbody to this gameObject!');

			Rigidbody2D rij = this.GetComponent<Rigidbody2D>();
			if(rij == null)
				Debug.LogError("You need to add a Rigidbody2D to this gameObject!");
			rij.AddForce(new Vector2(0f, 500));
//			rij.velocity = Vector2.up*10;

			print("shooting upwards");

		}
	
	}
}
