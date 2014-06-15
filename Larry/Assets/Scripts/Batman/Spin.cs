using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

	// Float to adjust the speed of the spin (tweakable inside the inspector

	public float speed = 10f;

	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up, Time.deltaTime*speed);
		transform.Rotate(Vector3.right, Time.deltaTime*speed/2);
	}
}
