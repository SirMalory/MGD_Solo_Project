using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
    public Unit Spawn(Unit unitPrefab, Transform location)
    {
        //Spawn and Hold Component Type
        Unit newUnit = Instantiate(unitPrefab,
            location.position, location.rotation);
        //ADD SPAWN EFFECTS LATER
        return newUnit;
    }
}
