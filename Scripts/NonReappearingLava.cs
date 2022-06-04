using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NonReappearingLava : MonoBehaviour
{
    public Collider2D playerObject;
    public Collider2D lavaObject;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Reappear());
        playerObject = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();
        lavaObject = GameObject.FindGameObjectWithTag("Lava").GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update() {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
