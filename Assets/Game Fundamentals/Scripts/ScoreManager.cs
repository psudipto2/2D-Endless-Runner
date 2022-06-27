using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    private float PlayerScore;
    private void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            PlayerScore += 1 * Time.deltaTime;
            ScoreText.text = ((int)PlayerScore).ToString();
        }
    }
}
