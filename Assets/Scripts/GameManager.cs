using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player hamdi = new Player("Hamdi", 77);
        Enemy sharshabeel = new Enemy("Sharshabeel", 55);
        
        Debug.Log(hamdi.Name + "  " + hamdi.Health);
        Debug.Log(sharshabeel.Name + "  " + sharshabeel.Health);

        hamdi.Heal(10);
        Debug.Log(hamdi.Health);

        sharshabeel.Attack(20, hamdi);
        Debug.Log(hamdi.Health);
       
    }

}
