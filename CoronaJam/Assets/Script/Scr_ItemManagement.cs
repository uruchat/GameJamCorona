using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_ItemManagement : MonoBehaviour
{
    public Scr_Manager manager;
    public bool pickUpAllowed = false;
    public Scr_NPC npc;
    public bool dropOffAllowed = false;
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
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.Q))
        {
            Drop();
        }
        if (dropOffAllowed && Input.GetKeyDown(KeyCode.Q))
        {
            Give();
        }
        
    }
    // Fonctions
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Avatar") && !this.CompareTag("DropOff"))
        {
            pickUpAllowed = true;
        }
        {
            
            dropOffAllowed = true;
            
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        pickUpAllowed = false;
        dropOffAllowed = false;
        
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
    private void Drop()
    {
        if (this.CompareTag("PotionShelf") && manager.potionNbr >= 1)
        {
            manager.potionNbr--;
            manager.total--;
        }
        if (this.CompareTag("MaskShelf") && manager.maskNbr >= 1)
        {
            manager.maskNbr--;
            manager.total--;
        }
    }
    private void Give()
    {
        if (this.CompareTag("DropOff") && npc.produit_1 >= manager.potionNbr)
        {
            npc.produit_1 -= manager.potionNbr;
            manager.total -= manager.potionNbr;
            manager.potionNbr -= manager.potionNbr;
        }
        if (this.CompareTag("DropOff") && npc.produit_1 <= manager.potionNbr)
        {
            manager.total -= npc.produit_1;
            manager.potionNbr -= npc.produit_1;
            npc.produit_1 = 0;
        }
        if (this.CompareTag("DropOff") && npc.produit_2 >= manager.maskNbr)
        {
            npc.produit_2 -= manager.maskNbr;
            manager.total -= manager.maskNbr;
            manager.maskNbr -= manager.maskNbr;
        }
        if (this.CompareTag("DropOff") && npc.produit_2 <= manager.maskNbr)
        {
            manager.total -= npc.produit_2;
            manager.maskNbr -= npc.produit_2;
            npc.produit_2 = 0;
        }
    }
    
}
