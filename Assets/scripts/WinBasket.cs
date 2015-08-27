using UnityEngine;
using System.Collections;

public class WinBasket : MonoBehaviour {

	private bool levelWon = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.Space))
			Application.LoadLevel(Application.loadedLevel+1);
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Crate")
		{
			//Application.LoadLevel(Application.loadedLevelName);
			print("You Win! Press P to go to new level");
			levelWon = true;

		}
	}
}
