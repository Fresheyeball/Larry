using UnityEngine;
using System.Collections;

public class CheckState : MonoBehaviour {

	public GameObject myObject;
	// Use this for initialization
	void Start () {
		Debug.Log ("Active Self: " + myObject.activeSelf);
		Debug.Log("Active in Hierarchy: " + myObject.activeInHierarchy);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
