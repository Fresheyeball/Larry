using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	void Awake(){
		rigidbody.freezeRotation = true;
	}

	void FixedUpdate(){
		float rotation     = Input.GetAxis ("Horizontal");
		rigidbody.AddForce (transform.forward * getSpeed());
	}

	float getSpeed(){
		float acceleration = Input.GetAxis ("Vertical");
		Debug.Log (acceleration);
		if (acceleration > 0f) {
			return acceleration * speed;
		} else {
			return 0f;
		}
	}

}