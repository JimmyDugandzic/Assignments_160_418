
/*****************************************************************************
// File Name : Fruits.cs
// Author : Jimmy D.
// Creation Date : 1/25/2024
//
// Brief Description : Script for making my fruits for their color, name and weight
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

//no start and update bc no monobehavour
public class Fruit
{
    public string name;
    public string color;
    public float weight;

    /// <summary>
    /// constructor for fruit class that takes 3 parameters
    /// </summary>
    /// <param name="name">name of fruit</param>
    /// <param name="c">color of fruit</param>
    /// <param name="w">weight of fruit</param>




    public Fruit(string name, string c, float w)        // can help add new fruit on the other code list of "fruits"
    {
        this.name = name;
        color = c;
        weight = w;
    }


    public Fruit()                                      // if the parameters is 0 than it will always add blue banna with 3.7f weight
    {
        name += "banana";
        color = "blue";
        weight = 3.7f;

    }

    public Fruit(string name)                           //
    {
        this.name = name;
        color = "red";
        weight = 1.0f;

        
    }

    public Fruit(float weight)                         // any thing that is 7.8 units than its classed as a watermelon automatically
    {
        name = "watermelon";
        color="white";
        this.weight = weight;
    }

    ~Fruit()                                          // disruptor, basically reseting everything back to 0 
    {
        // write to a file
        name = "";
        weight = 0f;
        color = "clear";
    }
}
