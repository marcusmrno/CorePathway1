using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManagement : MonoBehaviour
{
    /**
        -Inventory
        -collect items into inv
        -simple menus, hud only
        -Wheel to select item
        -item shows up in hand, bottom right
        -throw items, based on holding down mouse 1?
    **/

    
    public GameObject grabBox;//hitbox for the area we can pick up items in
    [HideInInspector]public List<GameObject> inventory = new List<GameObject>(); // will hold our items
    private Transform hand;//where items will be placed when held
    private int heldIndex;//index in the inventory list of the current held item

    public GameObject getItem(int index)//return a gameobject from the invetory list using its index (slot - 1)
    {
        return inventory[index];
    }

    private void manageItem(GameObject item)//manages pickup/droping of items
    {
        if (Input.GetKeyDown("e"))
        {
            inventory.Add(item);
            heldIndex = inventory.Count;
        }

        3
    }
 }
