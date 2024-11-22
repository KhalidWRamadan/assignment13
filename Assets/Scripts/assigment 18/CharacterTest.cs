using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assigment18
{
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {
            Character[] characters = new Character[4];
            Soldier mazen = new Soldier();
            Soldier ahmed = new Soldier();
            Officer moaty = new Officer("moaty", 99, new Position(1.5f, 0, 6.6f));
            Officer sleem = new Officer("sleem", 50, new Position(1.7f, 10, 9.2f));

            characters[0] = mazen;
            characters[1] = ahmed;
            characters[2] = moaty;
            characters[3] = sleem;

            foreach (Character character in characters)
                character.DisplayInfo();


            Debug.Log(mazen.Health);
            moaty.Attack(28, mazen);
            Debug.Log(mazen.Health);

            Debug.Log(ahmed.Health);
            sleem.Attack(70, ahmed, "Shallooot");
            Debug.Log(ahmed.Health);


        }
    }
}
