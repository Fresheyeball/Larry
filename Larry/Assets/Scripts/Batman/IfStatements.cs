using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {
	public float coffeeTemperature = 85f;
	public float hotLimitTemperature = 70f;
	public float coldLimitTemperature = 40f;
	public float roomTemperature = 25f;

	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown (KeyCode.Space)) {
			TemperatureTest ();

		}
		if (coffeeTemperature > roomTemperature) {
			coffeeTemperature -= Time.deltaTime * 5f;
		}
	}

    void TemperatureTest() 
	{
			if (coffeeTemperature > hotLimitTemperature) {
				Debug.Log ("Too Hot");
			} else if (coffeeTemperature < coldLimitTemperature) {
				Debug.Log ("Too Cold");
			} else {
				Debug.Log ("Just Right");
			}
	}
}
