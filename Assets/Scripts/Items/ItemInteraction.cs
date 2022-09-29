using UnityEngine;

public class ItemInteraction : Interactable
{

    public Item item;
    public override void Interact()
    {
        Debug.Log("Interacting with " + item);
        base.Interact();
        PickUp();
    }

    void PickUp()
    {
        Debug.Log("Picking up " + item);
        Inventory.instance.Add(item);
        Destroy(gameObject);
    }

}
