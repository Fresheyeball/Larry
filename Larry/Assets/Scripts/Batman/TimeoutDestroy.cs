using UnityEngine;
using System.Collections;

public class TimeoutDestroy : MonoBehaviour
{

   public bool isEnabled = false;
   public float timeout = 3f;

   void Update ()
   {
      if (isEnabled) {
         timeout -= Time.deltaTime;
         if (timeout <= 0) {
            Destroy (gameObject);
         }
      }

   }

}
