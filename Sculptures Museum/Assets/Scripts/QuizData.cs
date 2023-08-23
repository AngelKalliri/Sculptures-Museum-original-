using System.Collections;
using UnityEngine;


[System.Serializable]
public class QuizData 
{
    public string name;
    
    public int pointsAdder;              //points for correct answer
    public QuestionData[] questions;    //list of q for quiz 1
}
