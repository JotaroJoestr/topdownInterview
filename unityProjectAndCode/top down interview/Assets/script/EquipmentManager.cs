using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
    #region
    public static EquipmentManager instance;

    void Awake()
    {
        instance = this;
    }
    #endregion
    public Animator anim;

    public Equipment[] currentEquipment;

    void Start()
    {
        int numSlots = System.Enum.GetNames(typeof(EquipmentSlot)).Length;
        currentEquipment = new Equipment[numSlots];
    }

    public void Equip(Equipment newItem)
    {
        int slotIndex = (int)newItem.equipSlot;

        currentEquipment[slotIndex] = newItem;

        check();
    }

    void check()
    {
        if (currentEquipment[0] != null)
        {
            if (currentEquipment[1] != null)
            {
                if (currentEquipment[0].name == "GreenHat" && currentEquipment[1].name == "GreenShirt")
                {
                    anim.SetBool("gHgS", true);
                    anim.SetBool("gHrS", false);
                    anim.SetBool("gHbS", false);

                    anim.SetBool("rHgS", false);
                    anim.SetBool("rHrS", false);
                    anim.SetBool("rHbS", false);

                    anim.SetBool("bHgS", false);
                    anim.SetBool("bHrS", false);
                    anim.SetBool("bHbS", false);
                }
                if (currentEquipment[0].name == "GreenHat" && currentEquipment[1].name == "RedShirt")
                {
                    anim.SetBool("gHgS", false);
                    anim.SetBool("gHrS", true);
                    anim.SetBool("gHbS", false);

                    anim.SetBool("rHgS", false);
                    anim.SetBool("rHrS", false);
                    anim.SetBool("rHbS", false);

                    anim.SetBool("bHgS", false);
                    anim.SetBool("bHrS", false);
                    anim.SetBool("bHbS", false);
                }
                if (currentEquipment[0].name == "GreenHat" && currentEquipment[1].name == "BlueShirt")
                {
                    anim.SetBool("gHgS", false);
                    anim.SetBool("gHrS", false);
                    anim.SetBool("gHbS", true);

                    anim.SetBool("rHgS", false);
                    anim.SetBool("rHrS", false);
                    anim.SetBool("rHbS", false);

                    anim.SetBool("bHgS", false);
                    anim.SetBool("bHrS", false);
                    anim.SetBool("bHbS", false);
                }

                if (currentEquipment[0].name == "RedHat" && currentEquipment[1].name == "GreenShirt")
                {
                    anim.SetBool("gHgS", false);
                    anim.SetBool("gHrS", false);
                    anim.SetBool("gHbS", false);

                    anim.SetBool("rHgS", true);
                    anim.SetBool("rHrS", false);
                    anim.SetBool("rHbS", false);

                    anim.SetBool("bHgS", false);
                    anim.SetBool("bHrS", false);
                    anim.SetBool("bHbS", false);
                }
                if (currentEquipment[0].name == "RedHat" && currentEquipment[1].name == "RedShirt")
                {
                    anim.SetBool("gHgS", false);
                    anim.SetBool("gHrS", false);
                    anim.SetBool("gHbS", false);

                    anim.SetBool("rHgS", false);
                    anim.SetBool("rHrS", true);
                    anim.SetBool("rHbS", false);

                    anim.SetBool("bHgS", false);
                    anim.SetBool("bHrS", false);
                    anim.SetBool("bHbS", false);
                }
                if (currentEquipment[0].name == "RedHat" && currentEquipment[1].name == "BlueShirt")
                {
                    anim.SetBool("gHgS", false);
                    anim.SetBool("gHrS", false);
                    anim.SetBool("gHbS", false);

                    anim.SetBool("rHgS", false);
                    anim.SetBool("rHrS", false);
                    anim.SetBool("rHbS", true);

                    anim.SetBool("bHgS", false);
                    anim.SetBool("bHrS", false);
                    anim.SetBool("bHbS", false);
                }

                if (currentEquipment[0].name == "BlueHat" && currentEquipment[1].name == "GreenShirt")
                {
                    anim.SetBool("gHgS", false);
                    anim.SetBool("gHrS", false);
                    anim.SetBool("gHbS", false);

                    anim.SetBool("rHgS", false);
                    anim.SetBool("rHrS", false);
                    anim.SetBool("rHbS", false);

                    anim.SetBool("bHgS", true);
                    anim.SetBool("bHrS", false);
                    anim.SetBool("bHbS", false);
                }
                if (currentEquipment[0].name == "BlueHat" && currentEquipment[1].name == "RedShirt")
                {
                    anim.SetBool("gHgS", false);
                    anim.SetBool("gHrS", false);
                    anim.SetBool("gHbS", false);

                    anim.SetBool("rHgS", false);
                    anim.SetBool("rHrS", false);
                    anim.SetBool("rHbS", false);

                    anim.SetBool("bHgS", false);
                    anim.SetBool("bHrS", true);
                    anim.SetBool("bHbS", false);
                }
                if (currentEquipment[0].name == "BlueHat" && currentEquipment[1].name == "BlueShirt")
                {
                    anim.SetBool("gHgS", false);
                    anim.SetBool("gHrS", false);
                    anim.SetBool("gHbS", false);

                    anim.SetBool("rHgS", false);
                    anim.SetBool("rHrS", false);
                    anim.SetBool("rHbS", false);

                    anim.SetBool("bHgS", false);
                    anim.SetBool("bHrS", false);
                    anim.SetBool("bHbS", true);
                }
            }
        }
    }
}

