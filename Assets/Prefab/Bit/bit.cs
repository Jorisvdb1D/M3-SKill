using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bit : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public bool state = false;
    

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.blue;
    }

     //Update is called once per frame
    void Update()
    {
        if (state)
        {
            spriteRenderer.color = Color.yellow;
        }
        else
        {
            spriteRenderer.color = Color.red;
        }

        
    }

    private void OnMouseUp()
    {
        state = !state;
    }
}
