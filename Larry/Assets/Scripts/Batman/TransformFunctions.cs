using UnityEngine;
using System.Collections;

public class TransformFunctions : MonoBehaviour
{

   public float moveSpeed = 100f;
   public float turnSpeed = 50f;
   // Use this for initialization
   void Start ()
   {

   }
	
   // Update is called once per frame
   void Update ()
   {
      float vertValue = Input.GetAxis ("Vertical");
      float horValue = Input.GetAxis ("Horizontal");

      if (vertValue != 0) {
         //transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
         rigidbody.AddForce (transform.forward * vertValue * moveSpeed * Time.deltaTime);
      }

      if (Input.GetAxis ("Horizontal") != 0) {
         rigidbody.AddTorque (transform.up * horValue * turnSpeed * Time.deltaTime);
         //transform.Rotate (Vector3.up * -turnSpeed * Time.deltaTime);
      }

   }

}
