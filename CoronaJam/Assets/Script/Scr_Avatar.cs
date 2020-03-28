using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//**Auteur Maxime Galarneau 27/03/2020**//

public class Scr_Avatar : MonoBehaviour
{
    private Transform tr;
    //private int Speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        tr = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        tr.Translate(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f) * Time.deltaTime * 10f, Space.World); //hori AD; verti WS, pas de Z, Time.deltaTime * Vitesse ajustable
    }
}
