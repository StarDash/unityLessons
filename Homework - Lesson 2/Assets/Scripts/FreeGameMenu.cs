using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FreeGameMenu : MonoBehaviour {

    public Button ok;

    void Start ()
    {
        ok.onClick.AddListener(OpenMainMenu);
    }

    void OpenMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
