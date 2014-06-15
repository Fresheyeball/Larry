using UnityEngine;
using System.Collections;

public class UpdateAndFixedUpdate : MonoBehaviour {

	void FixedUpdate() // regular timeline, physics
	{
		Debug.Log ("FixedUpdate time: " + Time.deltaTime);
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame, input etc
	void Update () { // non-physics
		Debug.Log ("Update time: " + Time.deltaTime);
	}

}
