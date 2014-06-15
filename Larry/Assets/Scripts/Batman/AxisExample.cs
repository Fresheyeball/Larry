using UnityEngine;
using System.Collections;

public class AxisExample : MonoBehaviour
{
   public float range;
   public GUIText textOutput;

   // Use this for initialization
   void Start ()
   {

   }
	
   // Update is called once per frame
   void Update ()
   {
      float h = Input.GetAxis ("Horizontal");

      float xPos = h * range;

      transform.position = new Vector3 (xPos, 2f, 0);
      textOutput.text = "Value Returned: " + h.ToString ("F2");
   }

}
