using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleUIHandler : MonoBehaviour
{
    public static TitleUIHandler Instance;
    public InputField nameInput;
    public string playerNameStr;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        { 
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update



    //Called by Quit Button on Title Screen, closes the game
    public void ExitGame()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
        Application.Quit();
        #endif
    }
    public void SetPlayerName()
    {
        playerNameStr = nameInput.text;
        SceneManager.LoadScene(1);
    }    

}
