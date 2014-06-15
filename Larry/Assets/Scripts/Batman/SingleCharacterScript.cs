using UnityEngine;
using System.Collections;

public class SingleCharacterScript : MonoBehaviour
{

   public class Stuff
   {
      public int bullets;
      public int grenades;
      public int rockets;

      public Stuff (int bul, int gre, int roc)
      {
         bullets = bul;
         grenades = gre;
         rockets = roc;
      }
   }

   public Stuff myStuff = new Stuff (100, 7, 25);
   public Rigidbody bulletPrefab;
   public Transform firePosition;
   public float bulletSpeed = 1000;
  

   void Update ()
   {
      firePosition = transform;
      Shoot ();
   }

   void Shoot ()
   {
      if (Input.GetButtonDown ("Fire1") && myStuff.bullets > 0) {

         Rigidbody bulletInstance = 
            Instantiate (bulletPrefab, 
                         firePosition.position, 
                         firePosition.rotation) as Rigidbody;
         bulletInstance.transform.Translate (Vector3.forward * 2);
         bulletInstance.GetComponent<TimeoutDestroy> ().isEnabled = true;
         bulletInstance.AddForce (firePosition.forward * bulletSpeed);
         myStuff.bullets--;
      }
   }
}
