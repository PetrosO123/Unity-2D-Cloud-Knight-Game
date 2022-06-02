using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruby_red : MonoBehaviour
{
    DiamondCounter diamondCounter;

    // Start is called before the first frame update
    void Start()
    {
        diamondCounter = GameObject.Find("DiamondCounter").GetComponent<DiamondCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 180f, 0f) * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Gem touched");
            for (int i = 0; i < 10; i++) {
                diamondCounter.diamondCount++;
            }
            gameObject.SetActive(false);
            Debug.Log("Collision with player detected. Diamond count: " + diamondCounter.diamondCount);
        }
    }
}
