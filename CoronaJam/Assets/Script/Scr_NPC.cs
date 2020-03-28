using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_NPC : MonoBehaviour
{
    public int produit_1 = 0; //papier Q
    public int produit_2 = 0; //bouffe
    private int nbrProduitMax = 5;

    public Text NPCNeed;

    // Start is called before the first frame update
    void Start()
    {
        NeedCreator();

    }

    // Update is called once per frame
    void Update()
    {
      //NPCNeed.text
    }

    void NeedCreator() //function pour creer le Randomizer de Besoin
    {
        produit_1 = Random.Range(0, nbrProduitMax);
        produit_2 = Random.Range(0, nbrProduitMax);
        
    }

}
