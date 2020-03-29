using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// AUTEUR : SAM

public class Scr_Manager : MonoBehaviour
{
    public int potionNbr = 0;
    public int maskNbr = 0;
    public int total = 0;
    public Scr_NPC modeleNPC;
    public float score = 0;
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = score.ToString(); // Met le score en string
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
        Vector3 posNPC = new Vector3(-300, -44, 0);
        Scr_NPC tempNPC = Instantiate(modeleNPC, posNPC, modeleNPC.transform.rotation);
        tempNPC.besoinAtteint = false;
        tempNPC.name = modeleNPC.name;
        
    }
}
