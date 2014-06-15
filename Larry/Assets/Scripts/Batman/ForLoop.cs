using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour {
	int numEnemies = 3;
	// Use this for initialization
	void Start () {
	   // when it enters
		for (int i = 0; i < numEnemies; i++) {
			Debug.Log ("Creating enemy number " + i);
		}
	}

}
