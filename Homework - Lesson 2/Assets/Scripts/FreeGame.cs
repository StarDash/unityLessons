using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FreeGame : MonoBehaviour {

    public Text playersCounter;
    public Text gameName;

    public GameObject freeGamePanel;
    public int playersInGame;
    public Button join;

    void Start()
    {
        join.onClick.AddListener(OpenFreeGameMenu);
    }

    void Update()
    {
        UpdateAmount();
        CheckLimit();
    }

    void CheckLimit()
    {
        if (playersInGame > 100)
        {
            join.GetComponent<Button>().interactable = false;
        }
        else
        {
            join.GetComponent<Button>().interactable = true;
        }
    }

    void UpdateAmount()
    {
        playersCounter.text = playersInGame.ToString();
    }

    void OpenFreeGameMenu()
    {
        SceneManager.LoadScene("Join");
    }
}
