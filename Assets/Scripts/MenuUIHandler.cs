using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public void ChangePlayerName(string name) {
        SaveManager.Instance.playerName = name;
    }

    public void StartNew() {
        SceneManager.LoadScene(1);
    }

    public void Exit() {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else    
            Application.Quit();
        #endif    
    }
}
