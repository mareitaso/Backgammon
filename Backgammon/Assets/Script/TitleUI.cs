using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TitleUI : MonoBehaviour
{
    public void ClickOnStart()
    {
        SceneManager.LoadScene("Main");
    }
}
