using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startEquipment : MonoBehaviour
{
    public Animator anim;
    public Equipment item, item2;
    public GameObject tutorUI;

    // Start is called before the first frame update
    void Start()
    {
        tutorUI.SetActive(true);

        Time.timeScale = 0f;

        anim.SetBool("gHgS", true);

    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.T))
        {
            get();

            Time.timeScale = 1f;

            tutorUI.SetActive(false);
        }
    }

    void get()
    {
        inventory.instance.Add(item);
        EquipmentManager.instance.Equip(item);

        inventory.instance.Add(item2);
        EquipmentManager.instance.Equip(item2);
    }

}
