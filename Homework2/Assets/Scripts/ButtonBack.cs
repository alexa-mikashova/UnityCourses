using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBack : MonoBehaviour
{
    public Button buttonBack;
    public Text text;
    public GameObject[] objectsToHide;
    public GameObject[] objectsToOpen;

    private Button[] buttonComponents;
    void Start()
    {
        buttonBack.onClick.AddListener(() =>
        {
            for (int i = 0; i < objectsToHide.Length; i++)
            {
                objectsToHide[i].SetActive(false);

                buttonComponents = objectsToHide[i].GetComponentsInChildren<Button>();

                for (int j = 0; j < buttonComponents.Length; j++)
                {
                    buttonComponents[j].interactable = true;
                }
            }

            for (int i = 0; i < objectsToOpen.Length; i++)
            {
                objectsToOpen[i].SetActive(true);
            }

            buttonBack.gameObject.SetActive(false);
            text.text = "Main Menu";
        });
    }
}
