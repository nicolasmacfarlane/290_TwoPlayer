using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text oneText;
    [SerializeField] private Text twoText;
    [SerializeField] private Text winText;
    public static int oneScore;
    public static int twoScore;

    void Start()
    {
        oneText.text = "Player 1: " + 0;
        twoText.text = "Player 2: " + 0;
    }

    public void AddScore1()
    {
        oneScore += 1;
        oneText.text = "Player 1: " + oneScore.ToString();
    }

    public void AddScore2()
    {
        twoScore += 1;
        twoText.text = "Player 2: " + twoScore.ToString();
    }

    void Update()
    {
        if (oneScore >= 5)
        {
            winText.text = "Player 1 Wins!";
        }

        else if (twoScore >= 5)
        {
            winText.text = "Player 2 Wins!";
        }
    }
}
