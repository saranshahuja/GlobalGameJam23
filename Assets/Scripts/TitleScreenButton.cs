using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenButton : MonoBehaviour
{
    public string titleScreenSceneName;
    public void goToTitleScreen()
    {
        SceneManager.LoadScene(titleScreenSceneName);
    }
}
