using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

public void BuildRoute()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Exit()
    {
        Debug.Log("EXIT!");
        Application.Quit();
    }

    public void Awake()
    {
        DontDestroyOnLoad(GameObject.FindGameObjectWithTag("GlobalValues"));
    }
}
