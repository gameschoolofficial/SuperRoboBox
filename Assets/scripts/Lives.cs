using UnityEngine;
using System.Collections;
using GameSchoolLibraries;

public class Lives : MonoBehaviour {
	public GameObject CharacterRobotBoy; 
	public GameObject Killzone;
	public int lives; 

	// Use this for initialization
	void Start () {
		print ("You have this many lives" + lives);
	}

	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D thingIHit)
{
		if (thingIHit.tag == "Killzone"){ }
			//god.decreaseLives (1); 
	}
}