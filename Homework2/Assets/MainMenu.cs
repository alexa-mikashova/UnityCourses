using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text textHeader;
    public GameObject back;
    public GameObject mainMenu;
    public Button buttons;
    public GameObject buttonsMenu;
    public Button toggles;
    public GameObject togglesMenu;
    public Button drops;
    public GameObject dropsMenu;
    public Button input;
    public GameObject inputMenu;
    public Button scrollView;
    public GameObject scrollViewMenu;

    private InputField[] inputsField;
    void Start()
    {
        buttons.onClick.AddListener(() =>
        {
            this.exitMainMenu("Buttons");
            buttonsMenu.SetActive(true);
        });

        toggles.onClick.AddListener(() =>
        {
            this.exitMainMenu("Toggle");
            togglesMenu.SetActive(true);
        });

        drops.onClick.AddListener(() =>
        {
            this.exitMainMenu("Drops");
            dropsMenu.SetActive(true);
        });

        input.onClick.AddListener(() =>
        {
            inputsField = inputMenu.GetComponentsInChildren<InputField>();

            for (int i = 0; i < inputsField.Length; i++)
            {
                inputsField[i].text = "";
            }
            this.exitMainMenu("Input");
            inputMenu.SetActive(true);
        });

        scrollView.onClick.AddListener(() =>
        {
            this.exitMainMenu("Scroll View");
            scrollViewMenu.SetActive(true);
        });
    }

    void exitMainMenu(string text)
    {
        textHeader.text = text;
        back.SetActive(true);
        mainMenu.SetActive(false);
    }
}
