using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventManager : MonoBehaviour
{
    public GameObject UIpanel;
    public Transform inventoryPanel;
    public List<SlotInventory> slots = new List<SlotInventory>();
    public bool isOpened;
    private Camera mainCamera;
    public float reachDistance = 2;

    void Start()
    {
        mainCamera = Camera.main;
        for(int i  = 0; i < inventoryPanel.childCount; i++)
        {
            if(inventoryPanel.GetChild(i).GetComponent<SlotInventory>() != null)
            {
                slots.Add(inventoryPanel.GetChild(i).GetComponent<SlotInventory>());
            }
        }
        UIpanel.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            isOpened = !isOpened;
            if(isOpened)
            {
                UIpanel.SetActive(true);
            }
            else
            {
                UIpanel.SetActive(false);
            }
        }
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, reachDistance ))
        {
            if(hit.collider.gameObject.GetComponent<Item>() != null)
            {

            }
        }
    }
    private void AddItem(Inventory _item, int _amount)
    {
        // foreach(SlotInventory slot in slots)
        // {
        //     if(slot.item == _item)
        //     {
        //         slots.amount += _amount;
        //         return;
        //     }
        // }
        // foreach(SlotInventory slot in slots)
        // {
        //     if(slots.isEmpty == false)
        //     {
        //         slots.item = _item;
        //         slots.amount = _amount;
        //     }
        // }
    }
}
