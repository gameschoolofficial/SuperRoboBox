using UnityEngine;
using System.Collections;


namespace GameSchoolLibraries {


	//A series of of functions made to simplify programming for beginners. 

	public static class GameSchoolLibraries
	{

		public static void parentIs ( this GameObject go, GameObject parent)
		{
			go.transform.parent = parent.transform;

		}

		public static void isEnabled(this GameObject go, bool trueOrFalse)
		{
			go.SetActive(trueOrFalse);

		}

		public static void lookAt3D(this GameObject go, GameObject other)
		{
			go.transform.LookAt(other.transform);
		}

		public static void addForce2D(this GameObject go, Vector2 direction)
		{
			Rigidbody2D rij = go.GetComponent<Rigidbody2D>();
			if(rij == null)
				Debug.LogError("You need to add a Rigidbody2D to this gameObject!");
			rij.AddForce(direction);
			//			rij.velocity = Vector2.up*10;
		}

		public static void gravityScale2D (this GameObject go, float scale)
		{
			Rigidbody2D rij = go.GetComponent<Rigidbody2D>();
			if(rij == null)
				Debug.LogError("You need to add a Rigidbody2D to this gameObject!");
			rij.gravityScale = scale;

		}

		public static void stopAllForces2D(this GameObject go2D)
		{
			Rigidbody2D rij2D = go2D.GetComponent<Rigidbody2D>();
			rij2D.isKinematic = true;
			rij2D.isKinematic = false;
			rij2D.velocity = new Vector2(0,0);
			rij2D.angularVelocity = 0;

		}

	}




}
