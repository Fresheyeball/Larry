using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour {
	int myInt = 4;
	// Use this for initialization
	void Start () {
	   // when it enters
		Debug.Log (MultiplyByTwo(myInt));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	int MultiplyByTwo(int number) {
		return number * 2;
    }
}
