using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour
{

   private Inventory inventory;

   public Rigidbody bulletPrefab;
   public Transform firePosition;
   public float bulletSpeed = 1000;
  
   void Awake ()
   {
      inventory = GetComponent<Inventory> ();
   }

   void Update ()
   {
      firePosition = transform;
      Shoot ();
   }

   void Shoot ()
   {
      if (Input.GetButtonDown ("Fire1") && inventory.myStuff.bullets > 0) {

         Rigidbody bulletInstance = 
            Instantiate (bulletPrefab, 
                         firePosition.position, 
                         firePosition.rotation) as Rigidbody;
         bulletInstance.transform.Translate (Vector3.forward * 2);
         bulletInstance.GetComponent<TimeoutDestroy> ().isEnabled = true;
         bulletInstance.AddForce (firePosition.forward * bulletSpeed);
         inventory.myStuff.bullets--;
      }
   }
}
