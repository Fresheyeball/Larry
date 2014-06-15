using UnityEngine;
using System.Collections;

public class ExplodingBullets : MonoBehaviour
{
   private Light myLight;
   private int  lightFrames = 5;
   // Use this for initialization
   void Start ()
   {
      myLight = GetComponent<Light> ();
   }
	

   void OnCollisionEnter (Collision collision)
   {
      myLight.enabled = true;
   }
   void OnCollisionStay (Collision collision)
   {
      if (lightFrames-- < 0) {
         myLight.enabled = false;
         Destroy (gameObject);
      }
   }
   void OnCollisionExit (Collision collision)
   {
      myLight.enabled = false;
      Destroy (gameObject);
   }

}
