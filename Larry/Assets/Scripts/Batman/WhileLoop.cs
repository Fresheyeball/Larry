using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {
	int cupsInTheSink = 4;
	// Use this for initialization
	void Start () {
	   // when it enters
		while (cupsInTheSink-- > 0) {
			Debug.Log ("I've washed a cup");
		}
	}

}
