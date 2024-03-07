using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
    public Unit _player;
    public void Spawn()
    {
        _player.Level_1();
        //ADD SPAWN EFFECTS LATER
    }
}
