using UnityEngine;
using System.Collections;

public class ForeachLoop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	   // when it enters
		string[] strings = new string[3];

		strings [0] = "first";
		strings [1] = "second";
		strings [2] = "third";
		foreach (string item in strings) {
			print (item);
		}
	}

}