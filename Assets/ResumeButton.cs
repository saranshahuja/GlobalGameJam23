using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButton : MonoBehaviour
{
    public GameObject pauseOverlay;
    public void Resume()
    {
        
        Time.timeScale = 0;
        pauseOverlay.SetActive(false);
    }
}
