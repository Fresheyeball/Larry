using UnityEngine;
using System.Collections;

public class BustDownDoor : MonoBehaviour
{
   public Camera theCamera;
   private Light myLight;
   // Use this for initialization
   void Start ()
   {
      myLight = GetComponent<Light> ();
   }
	
   // Update is called once per frame
   void OnMouseDown ()
   {
      if (theCamera) {
         rigidbody.AddForce (theCamera.transform.forward * 500);
      } else {
         rigidbody.AddForce (-transform.forward * 500);
      }
   }

   void OnCollisionEnter (Collision collision)
   {
      myLight.enabled = true;
   }
   void OnCollisionStay (Collision collision)
   {
      myLight.enabled = false;
   }
   void OnCollisionExit (Collision collision)
   {
      myLight.enabled = false;
   }

}
