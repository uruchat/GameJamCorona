using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Camera : MonoBehaviour
{
    private Vector3 Comptoir = new Vector3(0, 0, -10);
    private Vector3 Entrepot = new Vector3(0, 270.0f, -10);
    private bool moveToEntrepot = false;
    private bool moveToComptoir = false;
    public Transform Avatar;

    private float speed = 300.0f; //speed of camera

    public void TransitionCameraToEntrepot()
    {
        //this.transform.position = this.transform.position == Comptoir ? Entrepot : Comptoir;

        if (this.transform.position == Comptoir)
        {
            //this.transform.position = Entrepot;     
            moveToEntrepot = true;
        }
    }
    public void TransitionCameraToComptoir()
    {
        //this.transform.position = this.transform.position == Comptoir ? Entrepot : Comptoir;

        if (this.transform.position == Entrepot)
        {
            //this.transform.position = Entrepot;     
            moveToComptoir = true;
        }
    }


    public void Update()
    {

        // Temporary for testing
       /* if (Input.GetMouseButtonDown(0))
        {
            TransitionCamera();
        }*/

        if (moveToEntrepot)
        {
            // Move our position a step closer to the target.
            float step = speed * Time.deltaTime; // calculate distance to move
            this.transform.position = Vector3.MoveTowards(this.transform.position, Entrepot, step);
        }

        if (moveToComptoir)
        {
            // Move our position a step closer to the target.
            float step = speed * Time.deltaTime; // calculate distance to move
            this.transform.position = Vector3.MoveTowards(this.transform.position, Comptoir, step);
        }

        if (this.transform.position == Entrepot) { moveToEntrepot = false; }
        if (this.transform.position == Comptoir) { moveToComptoir = false; }



            if (Avatar.transform.position.y >= 135 && this.transform.position != Entrepot)
            {
                this.GetComponent<Scr_Camera>().TransitionCameraToEntrepot();
            }
            if (Avatar.transform.position.y <= 135 && this.transform.position != Comptoir)
            {
                this.GetComponent<Scr_Camera>().TransitionCameraToComptoir();
            }

    }
}
