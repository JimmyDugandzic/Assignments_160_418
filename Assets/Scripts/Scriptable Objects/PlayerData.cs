using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : ScriptableObject
{
    [SerializeField] private string Playername;
    [SerializeField] private int PlayerHealth;

    public string Playername1 { get => Playername; set => Playername = value; }
    public int PlayerHealth1 { get => PlayerHealth; set => PlayerHealth = value; }
}
