using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsButton : MonoBehaviour
{
    public string optionsSceneName;
    public void GoToOptions()
    {
        SceneManager.LoadScene(optionsSceneName);
    }
}
