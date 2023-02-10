using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManagement : MonoBehaviour
{
    /**
        -Inventory
        -collect items into inv
        -simple menus, hud only
        -item shows up in hand, bottom right
        -throw items, based on holding down mouse 1?
    **/

    
    public GameObject grabBox;//hitbox for the area we can pick up items in
    private Transform hand;//where items will be placed when held
    [HideInInspector] public List<GameObject> inventory = new List<GameObject>(); // will hold our items
    private int heldIndex = 0;//index in the inventory list of the current held item

    [SerializeField] private GameObject hud;

    public GameObject getItem(int index)//return a gameobject from the invetory list using its index (slot - 1)
    {
        return inventory[index];
    }

    public void addItem(GameObject item)
    {
        inventory.Add(item);
    }

    public void removeItem(GameObject item)
    {
        inventory.Remove(item);
    }

    private void pickupItem(GameObject item)
    {
        if (Input.GetKeyDown("e"))
        {
            addItem(item);
            heldIndex = inventory.Count;
        } 
    }

    private void dropItem()
    {
        if (Input.GetKeyDown("q"))
        {
            removeItem(getItem(heldIndex));
        }
    }

    public void Update()
    {
        manageInHands();
    }

    private void manageInHands()//manages what item is held
    {
        for(int i=1; i<=5; i++)
        {
            if (Input.GetKeyDown("" + i)){
                heldIndex = i - 1;
                Debug.Log(heldIndex);
            }
        }
        //getItem(heldIndex).transform.position = hand.position;
        hud.GetComponent<HudManager>().selectedSlot(heldIndex);
    }
 }
