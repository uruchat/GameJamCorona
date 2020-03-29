using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_MenuManager : MonoBehaviour
{
    public GameObject UnityLogo;
    public SpriteRenderer spriteUnity;
    public Color colorUnity;
    // Start is called before the first frame update
    void Start()
    {
        spriteUnity = UnityLogo.GetComponent<SpriteRenderer>();
        colorUnity = spriteUnity.color;
        colorUnity.a -= 0.10f;

    }

    // Update is called once per frame
    void Update()
    {
        colorUnity =  new Vector4(colorUnity.r,colorUnity.g,colorUnity.b,colorUnity.a-0.1f);

    }
}
