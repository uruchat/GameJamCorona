using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_CountdownTimer : MonoBehaviour
{
    private float currentTime = 0f;
    private float startingTime = 25f; //duree en seconde du Timer

    public Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0"); //transfert de float a String.

        if (currentTime <= 0)
        {
            currentTime = 0; //si timer descent en bas de 0, il va rester a 0. Fonction a ajouter pour redemarrer lvl ou menu
        }
    }
}
