using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuperGame : MonoBehaviour {

    public Image playersAmountBar;
    public Text playersAmountText;
    public Text playersInGameCounterText;

    private float playersLimit = 500f;

    public float playersInGame;

    void Update()
    {
        UpdateAmount();
    }

    void UpdateAmount()
    {
        playersAmountBar.fillAmount = playersInGame / playersLimit;
        playersAmountText.text = playersInGame.ToString() + "/500";
        playersInGameCounterText.text = playersInGame.ToString();
        if (playersInGame > playersLimit)
        {
            playersAmountText.text = "500/500";
            playersInGameCounterText.text = "500";
        }
    }
}
