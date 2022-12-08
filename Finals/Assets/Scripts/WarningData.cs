using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WarningData : MonoBehaviour
{
    public void clickYes()
    {
        PlayerPrefs.DeleteKey("username");
        SceneManager.LoadScene("firstScene");
    }

    public void clickNo()
    {
        SceneManager.LoadScene("secondScene");
    }
}
