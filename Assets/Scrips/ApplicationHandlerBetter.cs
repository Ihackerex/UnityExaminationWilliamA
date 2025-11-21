using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This component can be used to access methods for changing the scene, and quitting the game
// It can be used together with UnityEventOnTrigger, or UI-button-events, to decide when a scene should be changed or the game should be closed
public class ApplicationHandler : MonoBehaviour
{
    [Header("Scene Loading")]
    [Tooltip("Build index of the scene to load (set in Build Settings).")]
    public int sceneIndex;

    public void ChangeScene()
    {
        if (sceneIndex >= 0 && sceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadSceneAsync(sceneIndex, LoadSceneMode.Single);
        }
        else
        {
            Debug.LogWarning($"Invalid sceneIndex '{sceneIndex}'. Check your Build Settings.");
        }
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log ("quitgame");
    }
}
