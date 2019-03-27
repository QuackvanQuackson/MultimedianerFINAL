using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionRandomizer : MonoBehaviour
{
    private const string QUESTIONDISPLAY = "QuestionDisplay";

    public void ChangeText ()
    {
        List<string> questions = new List<string> ();

        questions.Add("Was bedeutet HTML?");
        questions.Add("Was ist bei einem HTML Document der erste Tag?");
        questions.Add("Womit werden die Zeilen in C# getrennt?");
        questions.Add("Wofür steht css?");
        questions.Add("Was ist kein command für Git?");
        // 10 Fragen minimum

        int questionNumber = Random.Range (0,5);

        var QuestionRandom = GameObject.Find (QUESTIONDISPLAY);

        var text = QuestionRandom.GetComponent<Text> ();

        text.text = questions [questionNumber];
    }
}
