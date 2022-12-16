using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;
 public override void Interact()
    {
        base.Interact();
        PickUp();
    }

    void PickUp()
    {
        
        Debug.Log("picked up " + item.name);
        bool pickedUp = Inventory.instance.Add(item);

        if (pickedUp == true)
        {
            Destroy(gameObject);
        }
     
    }
}
