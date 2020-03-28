using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// AUTEUR : SAM

public class Scr_Manager : MonoBehaviour
{
    public int potionNbr = 0;
    public int maskNbr = 0;
    public int total = 0;
    public Scr_NPC modeleNPC;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
    if (potionNbr <= 0)
        {
            potionNbr = 0;
        }
    if (maskNbr <= 0)
        {
            maskNbr = 0;
        }
    if (total <= 0)
        {
            total = 0;
        }
    }
    public void SpawnNPC()
    {
        Vector3 posNPC = new Vector3(0f, 0f, 0f);
        Scr_NPC tempNPC = Instantiate(modeleNPC, posNPC, modeleNPC.transform.rotation);
    }
}
