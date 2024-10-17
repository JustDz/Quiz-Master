using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{

    int correctAnswer = 0;
    int questionsSeen = 5;

    public int GetCorrectAnswers()
    {
        return correctAnswer; //Getter Method
    }

    public void IncrementCorrectAnswers()
    {
        correctAnswer++; //Setter Method
    }

    public int GetQuestionSeen()
    {
        return questionsSeen;
    }

    public void IncrementQuestionSeen()
    {
        questionsSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt(correctAnswer / (float)questionsSeen * 100);
    }
}
