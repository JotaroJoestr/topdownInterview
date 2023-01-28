using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactable : MonoBehaviour
{
    public GameObject player;

    public GameObject E;

    public bool closeEnough = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (closeEnough)
            {
                interact();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            closeEnough = true;
            E.SetActive(true);
        }
        else
        {
            closeEnough = false;
            E.SetActive(false);
        }
    }




    private void OnTriggerExit2D(Collider2D collision)
    {
        closeEnough = false;
        E.SetActive(false);
    }

    public virtual void interact()
    {

    }

}

