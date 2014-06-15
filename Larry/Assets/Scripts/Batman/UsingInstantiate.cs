using UnityEngine;
using System.Collections;

public class UsingInstantiate : MonoBehaviour
{
   public Rigidbody rocketPrefab;
   public Transform barrelEnd;

   void Update ()
   {
      if (Input.GetButtonDown ("Fire2")) {
         Rigidbody rocketInstance;
         barrelEnd = transform;
         rocketInstance = Instantiate (rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
         rocketInstance.transform.Translate (Vector3.forward * -1);
         rocketInstance.AddForce (barrelEnd.forward * -5000);
      }
   }

}
