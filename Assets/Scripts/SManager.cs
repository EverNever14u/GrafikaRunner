using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SManager : MonoBehaviour
{
   public void GoStartGame()
    {
        Debug.Log("Changing scene to start game");
        SceneManager.LoadScene (2);
    }
    
    public void GoExitGame()
    {
        Debug.Log("ExitingGame");
        Application.Quit();
    }

    public void GoInstruction()

    {
        Debug.Log("Changing scene to instruction");
        SceneManager.LoadScene (1);  
    }

     public void GoMenu()

    {
         Debug.Log("Changing scene to menu");
         SceneManager.LoadScene (0);  
    }

}
