using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Factory",menuName = "Inventory/Buildings/new Building")]
public class BuildingItem : Inventory
{
    public int EnergyUse;
    private void Start()
    {
        itemType = ItemType.Building;
    }
}
