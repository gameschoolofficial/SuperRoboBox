using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UItest : MonoBehaviour {

	int lives = 3;
	public Text blah;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyUp(KeyCode.A))
		{
			lives = lives + 1;
				print("lives: " + lives);
			blah.text = "Lives: " + lives;

		}
	}
}
