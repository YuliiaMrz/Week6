using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] int Score;

    public Text ScoreText;

    public void OnClickButton()
    {
        Score++;
    }

    private void Update()
    {
        ScoreText.text = Score + "$";
    }
}
