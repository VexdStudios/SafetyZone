#region Using Methods
using Com.Kawaiisun.SimpleHostile;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#endregion

public class BetaUsernames : MonoBehaviour
{
    #region Start Method
    private void Start()
    {
        devMenu.SetActive(false);
    }
    #endregion

    #region Variables Poggers
    private string beta_zax = "Zax";
    private string beta_niqht = "Niqht";
    public GameObject devMenu; 

    #endregion

    #region Beta Username Function
    // TODO
    //public static void BetaUser(string beta_zax, string beta_niqht)
    //{
     //   Player.ui_username.text = beta_zax;
    //}
    #endregion

    #region Developer Menu
    public void DevMenu()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Cursor.lockState = CursorLockMode.None;
            devMenu.SetActive(true);

        }
    }
    
    public void DevBackButton()
    {
        devMenu.SetActive(false);
    }
    #endregion
}
