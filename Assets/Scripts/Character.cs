

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
   private string name;
   private int health;

   public Character(string name, int health)
   {
      this.name = name;
      this.health = health;
   }
   public string Name
   {
      set
      {
         name = value;
      }
      get
      {
         return name;
      }
   }
   public int Health
   {
      set
      {
         if (health > 100)
            health = 100;
         else if (health < 0)
            health = 0;
         else
            health = value;
      }
      get
      {
         return health;
      }
   }
}
