
/*****************************************************************************
// File Name : FruitManager.cs
// Author : Jimmy D.
// Creation Date : 1/25/2024
//
// Brief Description : Script that lets me add the fruit to my salad/classes and use/print them in unity
*****************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FruitManager : MonoBehaviour
{

    public List<Fruit> FruitSalad;

    /// <summary>
    /// constructor for a list of my fruits
    /// </summary>
    
    void Start()
    {
        FruitSalad = new List<Fruit>();                        //defining the list of fruits

        Fruit apple = new Fruit("apple", "green", 1.2f);        // added new fruit called apple thats green and weighs 1.2 units
        FruitSalad.Add(apple);                                  //add apple to list

        CreateFruitSalad();
        DisplayFruitSalad();
    }

    private void DisplayFruitSalad()                            //
    {
        for (int i = 0; i < FruitSalad.Count; i++)
        {
          print(FruitSalad[i].color + " " + FruitSalad[i].name + " weighs " + FruitSalad[i].weight + " units");    // prints the color name and weight of the fruit
        }
    }

    private void CreateFruitSalad()                             //add new fruits to our class
    {
        FruitSalad.Add(new Fruit());

        FruitSalad.Add(new Fruit("strawberry"));

        FruitSalad.Add(new Fruit(7.8f));
    }

    void Update()
    {
        
    }
}
