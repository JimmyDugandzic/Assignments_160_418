using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    private string weaponName;
    private int weaponStrength;

    protected int WeaponStrength { get => weaponStrength; set => weaponStrength = value; }
    protected string WeaponName { get => weaponName; set => weaponName = value; }

    protected virtual void TakeDamage(int damage)
    {
        WeaponStrength -= damage;        //weaponStrength = weaponStrength - damage
    }
}
