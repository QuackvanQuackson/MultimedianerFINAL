using UnityEngine;

[CreateAssetMenu(menuName = "QuestionData")]
public class Question : ScriptableObject
{
    public string question = "";
    //0 richtig, 1-3 falsch
    public string[] answers = new string[4];
}
