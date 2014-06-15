using UnityEngine;
using System.Collections;

public class Hover : MonoBehaviour
{
   public float hoverForce = 15;

   // Use this for initialization
   void Start ()
   {

   }
	
   void OnTriggerStay (Collider other)
   {
      if (other.rigidbody) {
         other.rigidbody.AddForce (Vector3.up * hoverForce, ForceMode.Acceleration);
      }
   }

}
