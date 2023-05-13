using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    [SerializeField] private GameObject optionsCanvas;
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OpenOptions()
    {
        optionsCanvas.SetActive(true);
    }

    public void CloseOptions()
    {
        optionsCanvas.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
