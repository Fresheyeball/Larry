using UnityEngine;
using System.Collections;

public class ClickColourChange : MonoBehaviour
{

   // Use this for initialization
   void Start ()
   {
      Random.seed = (int)Time.time;
   }
	
   // Update is called once per frame
   void OnMouseDown ()
   {
      float r = Random.Range (0f, 1f);
      float g = Random.Range (0f, 1f);
      float b = Random.Range (0f, 1f);
      Color randomColour = new Color (r, g, b, 1f);

      renderer.material.color = randomColour;
   }

}
