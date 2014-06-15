using UnityEngine;
using System.Collections;

public class DestroyComponent : MonoBehaviour
{
   public float delay = 3;
   // Use this for initialization
   void Start ()
   {

   }
	
   // Update is called once per frame
   void Update ()
   {
      if (Input.GetKey (KeyCode.Space)) {
         Destroy (GetComponent<MeshRenderer> (), delay);
      }
   }

}
