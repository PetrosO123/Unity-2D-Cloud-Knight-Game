using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigger_cloud : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-0.008f, 0f, 0f));
    }
}
