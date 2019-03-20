using UnityEngine;
using UnityEngine.UI;

public class QuestionRandomizer : MonoBehaviour
{
    // Use this for initialization
    public void ChangeText ()
    {
        List<string> questions = new List<string> ();

        questions.Add("Was bedeutet HTML?");
        questions.Add("Was ist bei einem HTML Document der erste Tag?");
        questions.Add("Womit werden die Zeilen in C# getrennt?");
        questions.Add("Wofür steht css?");
        questions.Add("Was ist kein command für Git?");


        int questionNumber = Random.Range (0,5);

        var QuestionRandom = GameObject.Find ("QuestionDisplay");

        var text = QuestionRandom.GetComponent<Text> ();

        text.text = questions [questionNumber];
    }
}
