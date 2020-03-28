using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Camera : MonoBehaviour
{
    public Camera MainCamera;

    private Vector3 Comptoir = new Vector3(0, 0, 0);
    private Vector3 Entrepot = new Vector3(0, 10.8f, 0);

    public void TransitionOfRoom()
    {
        MainCamera.transform.position = MainCamera.transform.position == Comptoir ? Entrepot : Comptoir;
    }



}
