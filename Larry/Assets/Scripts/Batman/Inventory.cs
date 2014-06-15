using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{

   public class Stuff
   {
      public int bullets;
      public int grenades;
      public int rockets;
      public float fuel;
      
      public Stuff (int bul, int gre, int roc)
      {
         bullets = bul;
         grenades = gre;
         rockets = roc;
         fuel = 100f;
      }

      public Stuff (int bul, float fu)
      {
         bullets = bul;
         grenades = 1;
         rockets = 1;
         fuel = fu;
      }

      public Stuff ()
      {
         bullets = 1;
         grenades = 1;
         rockets = 1;
         fuel = 100f;
      }
   }

   public Stuff myStuff = new Stuff (1000, 5, 5);

   public Stuff otherStuff = new Stuff (50, 1.5f);

   void Start ()
   {
      Debug.Log (myStuff.bullets);
   }
}
