using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    #region Variables

    public GameObject OptionsMenu;
    public GameObject MainMenu;

    #endregion


    #region Methods

    public void ShowOptionsMenu ()
    {
      OptionsMenu.SetActive(true);
      MainMenu.SetActive(false);
    }

    public void ShowMainMenuFromOptions ()
    {
      OptionsMenu.SetActive(false);
      MainMenu.SetActive(true);
    }

    public void MultiplayerMenu ()
    {
      SceneManager.LoadScene("Menu");
    }

    public void SingleplayerMenu ()
    {
      SceneManager.LoadScene("Main Menu 1");
    }

    public void QuitGame()
    {
      Application.Quit();
    }

    #endregion
}
