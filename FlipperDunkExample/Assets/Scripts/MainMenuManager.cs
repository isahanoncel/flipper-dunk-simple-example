using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    public Text levelTxt;
    int level;
    void Start()
    {
        int playerLevel=PlayerPrefs.GetInt("lastLevel");
        if(level>1)
        {
            level=playerLevel;
        }
        else
        {
            level=1;
        }
         levelTxt.text="LVL "+level;
    }

    public void startLevel()
    {
        SceneManager.LoadScene(level);
    }
}
