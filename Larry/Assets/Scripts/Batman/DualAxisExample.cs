using UnityEngine;
using System.Collections;

public class DualAxisExample : MonoBehaviour
{
   public float range = 1;
   public GUIText textOutput;
   
   // Use this for initialization
   void Start ()
   {
      
   }
   
   // Update is called once per frame
   void Update ()
   {
      float h = Input.GetAxis ("Horizontal");
      float v = Input.GetAxis ("Vertical");
      float xPos = h * range;
      float yPos = v * range;
      
      transform.position = new Vector3 (xPos, yPos + 4, -4);
      textOutput.text = "Value Returned: " + h.ToString ("F2") + "\nVertical Value Returned: " + v.ToString ("F2");
   }
}
