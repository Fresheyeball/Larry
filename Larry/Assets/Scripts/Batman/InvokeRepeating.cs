using UnityEngine;
using System.Collections;

public class InvokeRepeating : MonoBehaviour
{

   public GameObject bubble;

   void Start ()
   {
      InvokeRepeating ("SpawnObject", 1, 1);
   }

   void SpawnObject ()
   {
      float x = Random.Range (-3.5f, 16.5f);
      float z = Random.Range (-10.5f, 9.5f);
      GameObject aBubble;
      aBubble = Instantiate (bubble, new Vector3 (x, 1.7f, z), Quaternion.identity) as GameObject;
      aBubble.rigidbody.AddForce (aBubble.transform.up * 500);


   }
}
