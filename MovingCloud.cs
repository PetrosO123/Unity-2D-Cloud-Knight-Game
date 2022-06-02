using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCloud : MonoBehaviour
{
    public float speed = 25f;
    bool swap = true;
    private SpriteRenderer spRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (swap)
        {
            mushroomRight();
        }
        if (!swap)
        {
            mushroomLeft();
        }
        if(transform.position.x >= -8f)
        {
            swap = false;
            spRenderer.flipX = true;
        }
        if (transform.position.x <= -30f)
        {
            swap = true;
            spRenderer.flipX = false;
        }

    }

    void mushroomRight()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
    void mushroomLeft()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
