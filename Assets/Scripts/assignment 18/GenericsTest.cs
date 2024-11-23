using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{

    void Start()
    {
        GameContainer<string> healthPotion = new GameContainer<string>();
        healthPotion.Item = "Health Potion";

        Debug.Log("Stored Item: " + healthPotion.Item);
        GameUtils.DescribeItem<string>(healthPotion.Item);
    }


}
