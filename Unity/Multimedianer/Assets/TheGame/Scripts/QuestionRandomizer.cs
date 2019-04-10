using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionRandomizer : MonoBehaviour
{

    public Text questionText = null;
    public Text b1 = null;
    public Text b2 = null;
    public Text b3 = null;
    public Text b4 = null;


    private const string QUESTIONDISPLAY = "QuestionDisplay";
    public Question[] questionsNew = new Question[10];

    public void ChangeText ()
    {
        /*List<string> questions = new List<string> ();

        questions.Add("Was ist ein Event?");
        questions.Add("Was sind die meistbenutzten Schleifen?");
        questions.Add("Was versteht man unter Bug");
        questions.Add("Was bedeutet HTML?");
        questions.Add("Was ist bei einem HTML Dokument der erste Tag?");
        questions.Add("Mit welchem Variablentyp kann eine Gleitkommazahl gespeichert werden?");
        questions.Add("Wofür steht CSS?");
        questions.Add("Welcher Command ist für Git?");
        questions.Add("Wofür steht SDK?");
        questions.Add("Was ist ein Kommentar?");
        //questions.Add("Was bedeutet HTML?");
        //questions.Add("Was ist bei einem HTML Document der erste Tag?");
        //questions.Add("Womit werden die Zeilen in C# getrennt?");
        //questions.Add("Wofür steht css?");
        //questions.Add("Was ist kein command für Git?");
        // 10 Fragen minimum
        */

        int questionNumber = Random.Range (0,9);

        var QuestionRandom = GameObject.Find (QUESTIONDISPLAY);

        var text = QuestionRandom.GetComponent<Text> ();

        questionText.text = questionsNew [questionNumber].question;

    }
}
