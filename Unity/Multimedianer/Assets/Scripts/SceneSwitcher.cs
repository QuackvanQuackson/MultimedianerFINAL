using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitcher : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Klick");
    }
}