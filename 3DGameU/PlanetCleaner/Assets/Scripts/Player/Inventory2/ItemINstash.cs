using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Stash/Item")]
public class ItemINstash : ScriptableObject
{
    public string Name;
    public int quantity;
}
