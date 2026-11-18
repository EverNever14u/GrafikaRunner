using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SManager : MonoBehaviour
{
    public void GoMenu()
    {
        Debug.Log("Changing scene to menu");
        SceneManager.LoadScene(0);
    }

    public void GoInstruction()

    {
        Debug.Log("Changing scene to instruction");
        SceneManager.LoadScene (1);  
    }

    public void GoConfirmExit()

    {
        Debug.Log("Changing scene to ConfirmExit");
        SceneManager.LoadScene(2);
    }

    public void GoStartGame()
    {
        Debug.Log("Changing scene to start game");
        SceneManager.LoadScene(3);
    }

    public void GoExitGame()
    {
        Debug.Log("ExitingGame");
        Application.Quit();
    }



}
