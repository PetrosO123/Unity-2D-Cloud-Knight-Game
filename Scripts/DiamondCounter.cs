using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondCounter : MonoBehaviour
{
    public int diamondCount = 0;
    Text diamondScore;

    private void Start()
    {
        diamondScore = GameObject.Find("DiamondScoreText").GetComponent<Text>();
    }

    private void Update()
    {
        diamondScore.text = "GemScore: " + diamondCount.ToString();
    }

    private void GemCounter()
    {
        
    }
}
