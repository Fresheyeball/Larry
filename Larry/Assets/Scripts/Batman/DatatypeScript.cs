using UnityEngine;
using System.Collections;

public class DatatypeScript : MonoBehaviour
{

   void Start ()
   {
      //Value type variable (int, float, double, bool, char, Vector3, Quaternion)
//      Vector3 pos = transform.position;
//      pos = new Vector3 (0, 2, 0);

      //Reference type variable (Classes: Transform, GameObject, etc)
      Transform tran = transform;
      tran.position = new Vector3 (0, 3, 0);
   }

}
