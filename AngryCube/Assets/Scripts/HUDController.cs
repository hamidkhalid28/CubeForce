using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public Text score_text;
    int score;

    private void Start()
    {
        score = 0;
        score_text.text = score.ToString();
    }

    public void UpdateScore()
    {
        score += 1;
        score_text.text = score.ToString();
    }
}
