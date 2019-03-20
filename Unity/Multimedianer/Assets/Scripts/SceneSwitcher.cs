using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    enum Scenes {Intro, Main, End}

    public void LoadIntroScene ()
    {
        SceneManager.LoadScene((int)Scenes.Intro);

    }

    public void LoadMainScene ()
    {
        SceneManager.LoadScene((int)Scenes.Main);
    }

    public void LoadEndScene()
    {
        SceneManager.LoadScene((int)Scenes.End);
    }
}