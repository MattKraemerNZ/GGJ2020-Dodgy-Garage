using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doozy.Engine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager ScoreManagerInstance;
    public static ScoreManager instance
    {
        get
        {
            if (ScoreManagerInstance == null)
            {
                ScoreManagerInstance = FindObjectOfType<ScoreManager>();
            }
            return ScoreManagerInstance;
        }
        // set
        // {
        //     this.name = value;
        // }
    }

    private float score;
    public float Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            print("Score is " + score + "!");
            ScoreText.text = "$" + score;
            // GameEventMessage.SendEvent("UpdateScore");
        }
    }

    public Text ScoreText;
}
