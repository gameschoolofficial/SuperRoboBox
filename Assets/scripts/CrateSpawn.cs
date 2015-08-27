using UnityEngine;
using System.Collections;

public class CrateSpawn : MonoBehaviour {


	public GameObject crate;

	// Use this for initialization
	void Start () {
		spawnCrate();
		

	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void spawnCrate()
	{
		print("spawn");
		Instantiate(crate, transform.position, Quaternion.identity);
		//StartCoroutine(WaitAndPrint(2.0F));
		//spawnCrate();

	}

	IEnumerator WaitAndPrint(float waitTime)
	{
		spawnCrate();
		yield return new WaitForSeconds(waitTime);
		print("cats");
		StartCoroutine(WaitAndPrint(2.0F));
	}

}
