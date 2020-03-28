using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_NPC : MonoBehaviour
{
    public int produitBesoin_1 = 0; //papier Q qu'il VEUT avoir
    public int produitBesoin_2 = 0; //bouffe qu'il VEUT avoir
    private int nbrProduitMax = 5;

    public int currentProduit_1 = 0; //papier Q qu'il a en main
    public int currentProduit_2 = 0; //bouffe qu'il a en main


    public Text NPCNeed;

    public float satisfactionPoint = 100f;

    // Start is called before the first frame update
    void Start()
    {
        NeedCreator();

    }

    // Update is called once per frame
    void Update()
    {
        //UI des Besoins et Invetaire du NPC
        //NPCNeed.text = ("Papier Q : {0} / {1} n/Bouffe : {2} / {3}", currentProduit_1, produitBesoin_1, currentProduit_2, produitBesoin_2);
        //probleme de String a Int  

        //Satisfaction du NPC. point qui descend avec le temps.

        satisfactionPoint -= 0.5f * Time.deltaTime;

        if (currentProduit_1 == produitBesoin_1 && currentProduit_2 == produitBesoin_2) { }
           
    }

    void NeedCreator() //function pour creer le Randomizer de Besoin
    {
        produitBesoin_1 = Random.Range(0, nbrProduitMax);
        produitBesoin_2 = Random.Range(0, nbrProduitMax);
        
    }

}
