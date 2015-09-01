using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public static GameManager gm; //{get; private set;}
	public GameObject pinkCube;
	public GameObject mainCharacter;

	// Use this for initialization
	void Awake () {

		gm = this;
	
	}

	public void setPinkCube(GameObject cube)
	{
		pinkCube = cube;
	}

	public void setMainCharacter(GameObject character)
	{
		mainCharacter = character;
	}




	
	// Update is called once per frame
	void Update () {
	
	}
}
