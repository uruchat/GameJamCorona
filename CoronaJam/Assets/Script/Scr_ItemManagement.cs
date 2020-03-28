using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_ItemManagement : MonoBehaviour
{
    public Scr_Manager manager;
    public bool pickUpAllowed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
        {
            PickUp();
        }

    }
    // Fonctions
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Avatar"))
        {
            pickUpAllowed = true;
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        pickUpAllowed = false;
    }
    private void PickUp()
    {
        if (this.CompareTag("PotionShelf") && manager.total < 5)
        {
            manager.potionNbr++;
            manager.total++;
        }
        if (this.CompareTag("MaskShelf") && manager.total < 5)
        {
            manager.maskNbr++;
            manager.total++;
        }
    }
}
