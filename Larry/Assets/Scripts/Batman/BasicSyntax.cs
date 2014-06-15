using UnityEngine;
using System.Collections;

public class BasicSyntax : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// when it enters
		Debug.Log (transform.position.x);

		/* This is a C style Comment */
		// this is a C++ style comment
		if (transform.position.y <= 5f) {
			Debug.Log("I'm about to hit the ground!!!!");
		}
	}

	// Update is called once per frame
	void Update () {

	}

}
