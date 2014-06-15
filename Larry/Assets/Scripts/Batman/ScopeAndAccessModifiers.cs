using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour
{
		public int alpha = 5;
		//private int beta = 0;
		//private int gamma = 5;// default is private
		private AnotherClass myOtherClass;

		// Use this for initialization
		void Start ()
		{
				// when it enters
				alpha = 29;
				myOtherClass = new AnotherClass ();
				myOtherClass.FruitMachine (alpha, myOtherClass.apples);
		}

		void Example (int pens, int crayons)
		{
				int answer;
				answer = pens * crayons * alpha;
				Debug.Log (answer);
		}
	
		// Update is called once per frame
		void Update ()
		{ 
				Debug.Log ("alpha is set to: " + alpha);
		}


}
