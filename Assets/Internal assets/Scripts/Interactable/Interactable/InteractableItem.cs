using Inventory;
using Item;
using UnityEngine;
namespace Interactable.Interactable
{
    public class InteractableItem : InteractableBase
    {
        [SerializeField] private InventoryObject inventory;

        public override void OnInteract()
        {
            var groundItem = gameObject.GetComponent<GroundItem>();

            if (!groundItem)
                return;
            
            var item = new Item.Item(groundItem.item);
            if (inventory.AddItem(item, 1))
            {
                Destroy(gameObject);
            }
        }
    }
}
