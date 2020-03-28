using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        tr.Translate(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f) * Time.deltaTime * 10f, Space.World);
    }
}
