using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;

    public GameObject hand;
    public GameObject gun;

    void Awake()
    {
        instance = this;
    }

    public List<Item> items = new List<Item>();

    public void Add (Item item)
    {
        Debug.Log("About to add " + item + " to inventory");
        if (items.Count == 1)
        {
            Debug.Log("Dropping " + items[0] + " and adding " + item + " to inventory");
            items.Remove(items[0]);     //Drops the current item
            items.Add(item);            //and adds the new item
        }
        else if (items.Count == 0)
        {
            Debug.Log("Adding " + item + " to inventory");
            items.Add(item);

            Transform handTrans = hand.transform;

            Instantiate(gun, handTrans.position, handTrans.rotation, handTrans.parent);
        }
        else
        {
            Debug.LogWarning("Too many items in inventory, try restarting");
        }
    }

    public void Remove (Item item)
    {
        items.Remove(item);
    }
}
