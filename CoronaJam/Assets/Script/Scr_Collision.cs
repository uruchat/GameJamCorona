using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Collision : MonoBehaviour
{
    public Scr_Avatar avatar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        avatar.canMove = true;
        
    }
    // Fonctions
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Avatar"))
        {
            avatar.canMove = false;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Avatar"))
        {
            avatar.canMove = true;
        }
    }
}
