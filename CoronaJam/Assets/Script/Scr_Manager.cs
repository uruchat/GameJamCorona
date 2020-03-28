using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// AUTEUR : SAM

public class Scr_Manager : MonoBehaviour
{
    public bool pickUpAllowed = false;
    public int potionNbr = 0;
    public int maskNbr = 0;
    public int total = 0;
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
        if (other.CompareTag = "Avatar")
        {
            pickUpAllowed = true;
        }
    }
    private void PickUp()
    {
        if (GameObject.CompareTag = "PotionShelf" && total < 5)
        {
            potionNbr++;
            total++;
        }
        if (GameObject.CompareTag = "MaskShelf" && total < 5)
        {
            maskNbr++;
            total++;
        }
    }
}
