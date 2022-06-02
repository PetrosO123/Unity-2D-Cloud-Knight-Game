using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormHoleScript : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(delayFlip());
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
        
    }

    IEnumerator delayFlip()
    {
        int x = 0;
        while (x < 1)
        {
            transform.Rotate(new Vector3(0f, 0f, 45f));

            yield return new WaitForSecondsRealtime(1);

            transform.Rotate(new Vector3(0f, 180f, -45f));

            yield return new WaitForSecondsRealtime(1);
        }
    }
}
