using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DescendingSpike : MonoBehaviour
{
    public float distance;
    public float speed = 25f;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
