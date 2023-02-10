using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudManager : MonoBehaviour
{
    [SerializeField] private GameObject inventoryBar;
    [HideInInspector] public List<GameObject> itemSlots = new List<GameObject>();//holds the frames for the itemslots

    private void Start()
    {
        for(int i=1; i<inventoryBar.transform.childCount; i++)//adds the frames to itemSlots list
        {
            itemSlots.Add(inventoryBar.transform.GetChild(i).gameObject);
        }
        Debug.Log(itemSlots.Count);
    }

    public GameObject getObjectSlot(int slot)
    {
        return itemSlots[slot];
    }

    public void addToSlot(GameObject item)//adds gameobject into slot
    {

    }

    public void removeFromSlot(int slot)//remvoes item from the slot
    {

    }

    public void selectedSlot(int slot)//moves ui elemecnts to show selected slot
    {
        for(int i=0; i<itemSlots.Count; i++)
        {
            if(i == slot)
            {
                itemSlots[i].GetComponent<FrameScript>().setFront();
            }
            else
            {
                itemSlots[i].GetComponent<FrameScript>().setBack();
            }
        }
    }
}
  