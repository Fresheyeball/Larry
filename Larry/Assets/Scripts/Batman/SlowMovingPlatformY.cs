using UnityEngine;
using System.Collections;

public class SlowMovingPlatformY : MonoBehaviour
{

   public float moveSpeed = 1f;
   public float moveRange = 4f;
   private float current = 0f;
   private float direction = 1f;
   // Use this for initialization
   void Start ()
   {

   }
	
   // Update is called once per frame
   void Update ()
   {

      if (current >= moveRange) {
         direction = -1f;
      } else if (current <= -moveRange) {
         direction = 1f;
      } 

      float move = moveSpeed * Time.deltaTime * direction;
      current += move;
      transform.Translate (Vector3.up * move);


   }

}
