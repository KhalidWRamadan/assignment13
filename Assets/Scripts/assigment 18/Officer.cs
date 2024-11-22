using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assigment18
{
    public class Officer : Character
    {
        public Officer(string name, int health, Position position) : base(name, health, position)
        {
        }
        public Officer() : base()
        {
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Debug.Log("Officer");
        }
    }
}
