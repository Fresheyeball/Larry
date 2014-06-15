using UnityEngine;
using System.Collections;

public class UsingDeltaTime : MonoBehaviour
{
   //public float speed = 8f;
   public float countdown = 3f;

   void Start ()
   {
      light.enabled = false;
   }
   void Update ()
   {

      countdown -= Time.deltaTime;

      if (countdown <= 0.0f) {
         light.enabled = !light.enabled;
         countdown = 3f;
      }
      //if (Input.GetKey (KeyCode.RightArrow)) {
      //   transform.position += new Vector3 (speed * Time.deltaTime, 0f, 0f);
      //}
   }

}
