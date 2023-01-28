using UnityEngine;

public class inventoryUI : MonoBehaviour
{
    public Transform itemParent;
    public GameObject InventoryUI;
    public GameObject shopUI, tutorUI;

    inventory inv;

    InventorySlot[] slots;
    // Start is called before the first frame update
    void Start()
    {
        inv = inventory.instance;
        inv.onItemChangedCallBack += UpdateUI;

        slots = itemParent.GetComponentsInChildren<InventorySlot>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            if (!tutorUI.activeSelf)
            {
                if (!shopUI.activeSelf)
                {
                    InventoryUI.SetActive(!InventoryUI.activeSelf);
                }
            }
        }
    }

    void UpdateUI()
    {
        
        for(int i = 0; i <slots.Length; i++)
        {
            if (i < inv.items.Count)
            {
                slots[i].AddItem(inv.items[i]);    
            }
            else
            {
                slots[i].Clear();
            }
        }
    }
}
