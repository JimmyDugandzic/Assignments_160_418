using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private EnemyData EnemyData;

   
    void Start()
    {
        print(EnemyData.EnemyName1 + " has " + EnemyData.EnemyHealth1 + " health ");
    }

   
    void Update()
    {
        if (Input.GetKey(KeyCode.A))       //when press a prints out enemy name "has" grabs the current health and "helath"
        {
            EnemyData.Attacked(10);
            print(EnemyData.EnemyName1 + " has " + EnemyData.EnemyHealth1 + " health ");
        }
    }
}
