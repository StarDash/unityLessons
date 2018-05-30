using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownList : MonoBehaviour {

    public Dropdown dropdown;
    public GameObject panel;
    public GameObject freeGame;
    public GameObject superGame;

    private void Awake()
    {
        List<string> optionsArray = new List<string> { "BINGO", "GOLDEN", "BRONZE" };

        dropdown.onValueChanged.AddListener(delegate {
            PopulateDropdownList(dropdown, optionsArray);
        });

        PopulateDropdownList(dropdown, optionsArray);
    }

    private void PopulateDropdownList(Dropdown dropdown, List<string> optionsArray)
    {
        dropdown.options.Clear();

        foreach (string option in optionsArray)
        {
            dropdown.options.Add(new Dropdown.OptionData(option));
        }

        switch (dropdown.value)
        {
            case 0:
                AddPanelWithGames(1,2);
                break;
            case 1:
                 AddPanelWithGames(2, 3);
                break;
            case 2:
                AddPanelWithGames(3, 3);
                break;
        }
    }

    void AddPanelWithGames(int superGameAmount, int freeGameAmount)
    {
        foreach (Transform child in transform)
        {
            if (child.tag == "Panel")
                Destroy(child.gameObject);
        }

        var newPanel = Instantiate(panel);
        newPanel.transform.SetParent(gameObject.transform, false);

        for (int i = 0; i < superGameAmount; i++)
        {
            var newSuperGame = Instantiate(superGame);
            newSuperGame.transform.SetParent(newPanel.transform, false);
        }

        for (int i = 0; i < freeGameAmount; i++)
        {
            var newFreeGame = Instantiate(freeGame);
            newFreeGame.transform.SetParent(newPanel.transform, false);
        }
    }
}
