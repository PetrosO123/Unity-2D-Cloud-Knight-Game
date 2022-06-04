using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom_2 : MonoBehaviour
{
    float mushroomTimer;
    int x = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(true);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            x++;
            if (x == 2)
            {
                gameObject.SetActive(false);
                mushroomTimer = Time.time + 5;
            }
        }
    }
}
