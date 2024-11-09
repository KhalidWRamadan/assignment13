using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player1 = new Player();
        Player player2 = new Player();

        player1.InitializePlayer("Khalid", 90);
        player2.InitializePlayer("Ali", 80);

        player1.Heal(5);
        player2.Heal(true);

        Player.ShowPlayerCount();
    }

}
