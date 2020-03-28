using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Timer : MonoBehaviour
{
    public int duree = 180;
    public int tempsRestant;
    public bool tempsDescend = false; 

    // Start is called before the first frame update
    /*void Start()
    {
        public void TimerOn()
        {
            if (!tempsDescend)
            {
                tempsDescend = true;
                tempsRestant = duree;
                invoke("TimerDown", 1f);
            }
        }

        private TimerDown()
        {

        }
    }

        

    // Update is called once per frame
    void Update()
    {
        
    }
}
