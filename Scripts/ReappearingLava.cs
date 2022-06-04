using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReappearingLava : MonoBehaviour
{

    public Renderer render;
    public Collider2D playerObject;
    public Collider2D lavaObject;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
        render.enabled = true;
        playerObject = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();
        lavaObject = GameObject.FindGameObjectWithTag("Lava").GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bool oddeven = Mathf.FloorToInt(Time.time) % 2 == 0;
        render.enabled = oddeven;
        if (render.enabled == false)
        {
            //Debug.Log("Lava is inactive");
        }
        if (render.enabled == true)
        {
            if (playerObject.IsTouching(lavaObject))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            ///Debug.Log("Lava is active");
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && render.enabled)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
