using UnityEngine;
using System.Collections;

public class DestroyOther : MonoBehaviour
{
   public GameObject other;

   // Use this for initialization
   void Start ()
   {

   }
	
   // Update is called once per frame
   void Update ()
   {
      if (Input.GetKey (KeyCode.Space)) {
         Destroy (other);
      }
   }

}
