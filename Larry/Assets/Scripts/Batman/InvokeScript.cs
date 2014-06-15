using UnityEngine;
using System.Collections;

public class InvokeScript : MonoBehaviour
{

   public GameObject target;

   void Start ()
   {
      Invoke ("SpawnObject", 2);
   }

   void SpawnObject ()
   {
      Instantiate (target, new Vector3 (0, 4, 0), Quaternion.identity);
   }
}
