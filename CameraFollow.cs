using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    GameObject character;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        offset.x = character.transform.position.x;
        offset.y = character.transform.position.y + 12;
        transform.position = offset;
    }
}
