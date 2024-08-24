using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public Button Scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveTitle()
    {
        SceneManager.LoadScene("Title");
    }

    public void MoveSetting()
    {
        SceneManager.LoadScene("TimeSetting");
    }

    public void MoveMain() 
    {
        SceneManager.LoadScene("Main");
    }
}
