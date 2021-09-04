using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CampaignError : MonoBehaviour
{
    public void BackButton ()
    {
      SceneManager.LoadScene("Main Menu");
    }
}
