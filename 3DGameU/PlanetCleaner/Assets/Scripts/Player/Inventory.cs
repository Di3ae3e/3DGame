using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public enum ItemType {Building, Weapon}

public class Inventory : ScriptableObject
{
    public string ItemName;
    public int maxAmount;
    public GameObject itemPrefab;
    public ItemType itemType;
    public string ItemDescription;
}
