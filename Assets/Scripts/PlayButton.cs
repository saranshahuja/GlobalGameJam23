using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public string startScene;
    public void PlayGame()
    {
        SceneManager.LoadScene(startScene);
    }
}
