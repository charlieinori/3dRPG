using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "new item";
        public Sprite icon = null;
        public bool isDefaultItem = false;
}
