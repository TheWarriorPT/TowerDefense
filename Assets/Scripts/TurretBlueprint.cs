﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class TurretBlueprint
{
    public GameObject turretPrefab;
    public int cost;

    public GameObject upgradedPrefab;
    public int upgradeCost;

    public int GetSellAmout()
    {
        return cost / 2;
    }
}
