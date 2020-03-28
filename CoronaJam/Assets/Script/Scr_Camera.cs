using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Camera : MonoBehaviour
{
    private Vector3 Comptoir = new Vector3(0, 0, -10);
    private Vector3 Entrepot = new Vector3(0, 10.8f, -10);

    public void TransitionCamera()
    {
        this.transform.position = this.transform.position == Comptoir ? Entrepot : Comptoir;
    }


    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TransitionCamera();
        }
    }
}
