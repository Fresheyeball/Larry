using UnityEngine;
using System.Collections;

public class Pop : MonoBehaviour
{

   // Use this for initialization
   void Start ()
   {

   }
	
   void OnTriggerEnter (Collider other)
   {
      if (!other.isTrigger) {
         Destroy (gameObject);
      }
   }

}
