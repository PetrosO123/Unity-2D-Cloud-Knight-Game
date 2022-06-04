using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaTileMoving : MonoBehaviour
{
    public float speed = 25f;
    bool swap = true;
    private SpriteRenderer spRenderer;
    // Start is called before the first frame update
    private void Start()
    {
        spRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (swap)
        {
            lavaBlockDown();
        }
        if (!swap)
        {
            lavaBlockUp();
        }
        if (transform.position.y <= -8f)
        {
            swap = false;
            spRenderer.flipY = true;
        }
        if (transform.position.y >= -30f)
        {
            swap = true;
            spRenderer.flipY = false;
        }

    }

    void lavaBlockDown()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }
    void lavaBlockUp()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
