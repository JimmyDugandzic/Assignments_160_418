using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private List<Weapon> weapons;
   
    void Start()
    {
        weapons.Add(new Gun());
    }

    
    
}
