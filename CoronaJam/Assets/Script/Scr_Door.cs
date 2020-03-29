using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Door : MonoBehaviour
{
    public Transform Avatar;
    public Camera MainCamera;
    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Avatar"))
        {

            if (Avatar.transform.position.y <= 135)
            {
                MainCamera.GetComponent<Scr_Camera>().TransitionCameraToEntrepot();
            }
            if (Avatar.transform.position.y >= 135)
            {
                MainCamera.GetComponent<Scr_Camera>().TransitionCameraToComptoir();
            }
        }
    }*/


   /* public void Update()
    {
        if (Avatar.transform.position.y >= 135 )
        {
            MainCamera.GetComponent<Scr_Camera>().TransitionCameraToEntrepot();
        }
        if (Avatar.transform.position.y <= 135 )
        {
            MainCamera.GetComponent<Scr_Camera>().TransitionCameraToComptoir();
        }
    }*/


}
