using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_NPC : MonoBehaviour
{
    //private Transform tr;

    public int produit_1 = 0;
    public int produit_2 = 0;
    private int nbrProduitMax = 5 + 1;
    private bool besoinAtteint= false;


    public Text NPCNeed;

    public float satisfactionPoint;
    public float satisfactionMaxPoint = 100f;
    public Slider satisfactionBar;

    public float score = 0f;
    public bool canGiveScore = true;

    
    public float moveSpeed = 50f;

   
    public  Transform[] waypoints; //tableau de waypoint dans Inspector
    private int waypointIndex = 0; //demarre au waypoint 0

    // Start is called before the first frame update
    void Start()
    {
        //tr = this.transform;
        NeedCreator(); //appele la creation du besoin
        satisfactionPoint = satisfactionMaxPoint;
        satisfactionBar.value = CalculBar();

        transform.position = waypoints[waypointIndex].transform.position; //fait apparaitre le NPC sur le 1er Waypoint 0
       
    }

    // Update is called once per frame
    void Update()
    {
        //UI des Besoins et Invetaire du NPC
        //NPCNeed.text = ("Potion : {0} / {1} n/Mask : {2} / {3}", currentProduit_1, produitBesoin_1, currentProduit_2, produitBesoin_2);
        //probleme de String a Int  

        Move();

        //Satisfaction du NPC. Points qui descendent avec le temps
        satisfactionPoint -= 2f * Time.deltaTime; //ajustement si necessaire     
        satisfactionBar.value = CalculBar();

        if (produit_1 == 0 && produit_2 == 0 && canGiveScore == true)
        {
            score += satisfactionPoint;
            canGiveScore = false;
        }     
           
    }

    /*private void OnBecameInvisible()
    {
        Destroy(this.gameObject); //destruction du NPC quand sort de l'ecran. //disparait quand on va dans le Backstore
    }*/

    //Mes Fonctions
    void NeedCreator() //function pour creer le Randomizer de Besoin
    {
        //produit_1 = Random.Range(0, nbrProduitMax);
        //produit_2 = Random.Range(0, nbrProduitMax);
        
    }

    float CalculBar() //donne un pourcentage pour le Slider
    {
        return satisfactionPoint / satisfactionMaxPoint; 
    }

    void Move() //faire bouger le NPC sur les waypoints
    {
       

        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);

        if (transform.position == waypoints[waypointIndex].transform.position)
        {
            waypointIndex++;
        }

        /*if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }*/
        /*transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);

        if (transform.position == waypoints[1].transform.position)
        {
            waypointIndex++;
            transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);
        }

        if (transform.position == waypoints[2].transform.position)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[3].transform.position, moveSpeed * Time.deltaTime);
        }

        //if (produit_1 == 0 && produit_2 == 0)
        if (transform.position == waypoints[3].transform.position)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[4].transform.position, moveSpeed = 50 * Time.deltaTime);
        }*/

    }
}
