using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMove : MonoBehaviour
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
        bool oddeven = Mathf.FloorToInt(Time.time) % 2 == 0;
        if (oddeven)
        {
            transform.Rotate(new Vector3(0f, 0f, 1f));
        }
        if (swap)
        {
            blockRight();
        }
        if (!swap)
        {
            blockLeft();
        }
        if (transform.position.x >= -8f)
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

    void blockRight()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
    void blockLeft()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
