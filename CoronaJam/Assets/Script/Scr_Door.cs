using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Door : MonoBehaviour
{
    public Camera MainCamera;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Avatar"))
        {
            MainCamera.GetComponent<Scr_Camera>().TransitionCamera();
        }
    }

}
