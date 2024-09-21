using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{

    public void Climb()
    {
        Debug.Log($"{Name} Climb");
    }
    private void Start()
    {
        //show Rabbit name, hp, speed, hunger
        Name = "Cat";
        Debug.Log($"Name {Name} has health: {Health}, Speed: {Speed}, Hunger: {GetHunger()}");
        Eat(food[0]);
        Move();
        Sleep();

    }
}
