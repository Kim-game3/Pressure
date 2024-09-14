using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public Button Scene;
    public static bool S_Four = false;
    public static bool S_Three = false;
    public static bool S_Two = false;

    public void MoveTitle()
    {
        SceneManager.LoadScene("Title");
    }

    public void MoveSetting()
    {
        SceneManager.LoadScene("TimeSetting");
    }

    public void MoveMain_Four() 
    {
        S_Four = true; 
        SceneManager.LoadScene("Main");
    }

    public void MoveMain_Three()
    {
        S_Three = true;
        SceneManager.LoadScene("Main");
    }

    public void MoveMain_Two() 
    {
        S_Two = true;
        SceneManager.LoadScene("Main");
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
