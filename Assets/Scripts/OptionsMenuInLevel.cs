using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenuInLevel : MonoBehaviour
{

    public GameObject optionsMenu;

    public void OpenOptions()
    {
      optionsMenu.SetActive(true);
    }

    public void CloseOptions()
    {
      optionsMenu.SetActive(false);
    }
}
