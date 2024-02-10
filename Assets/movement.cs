using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public int state = 1;

    public SpriteRenderer spriteRenderer;
    public Sprite circle;
    // public Sprite triangle;
    public Sprite square;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKeyDown("space"))
        {
            if(state==1)
            {
                state=2;
                spriteRenderer.sprite = square;
            }

            else
            {
                state=1;
                spriteRenderer.sprite = circle;
            }

        }

        if ((Input.GetKey(KeyCode.D))&&(spriteRenderer.sprite == circle))
        {
            transform.Translate(0.01f, 0, 0);
        }

        if ((Input.GetKey(KeyCode.A))&&(spriteRenderer.sprite == circle))
        {
            transform.Translate(-0.01f, 0, 0);
        }    
    }
}
