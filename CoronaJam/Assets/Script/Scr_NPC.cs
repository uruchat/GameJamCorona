using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_NPC : MonoBehaviour
{
    private Transform tr;

    

    public int produit_1 = 0; //potion qu'il VEUT avoir
    public int produit_2 = 0; //mask qu'il VEUT avoir
    private int nbrProduitMax = 5 + 1;


    public Text NPCNeed;

    public float satisfactionPoint = 100f;
    public float score = 0f;

    // Start is called before the first frame update
    void Start()
    {
        tr = this.transform;
        NeedCreator();

    }

    // Update is called once per frame
    void Update()
    {
        //UI des Besoins et Invetaire du NPC
        //NPCNeed.text = ("Potion : {0} / {1} n/Mask : {2} / {3}", currentProduit_1, produitBesoin_1, currentProduit_2, produitBesoin_2);
        //probleme de String a Int  

        //Satisfaction du NPC. Point qui descend avec le temps
        satisfactionPoint -= 0.5f * Time.deltaTime; //ajustement si necessaire

        if (Produit_1 == 0 && Produit_2 == 0) 
        { 
            score = satisfactionPoint; 
        }
        //doit sortir de l'ecran et etre detruit

       
           
    }
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject); //destruction du NPC quand sort de l'ecran. 
    }

    //Mes Fonctions
    void NeedCreator() //function pour creer le Randomizer de Besoin
    {
        produit_1 = Random.Range(0, nbrProduitMax);
        produit_2 = Random.Range(0, nbrProduitMax);
        
    }

}
