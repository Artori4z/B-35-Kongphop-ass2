using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : Animal
{

    private void Start()
    {
        //show Rabbit name, hp, speed, hunger
        Name = "Rabbit";
        Debug.Log($"Name {Name} has health: {Health}, Speed: {Speed}, Hunger: {GetHunger()}");
        Eat(food[1]);
        Move();
        Sleep();
    }
}
