using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseOverlay;
    public void PauseGame()
    {   
         pauseOverlay.SetActive(true);
        Time.timeScale = 1;
       
    }
    
}
