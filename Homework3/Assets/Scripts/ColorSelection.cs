using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelection : MonoBehaviour
{
    public GameObject colorButtons;
    public GameObject airplans;
    private MeshRenderer[] airplansArray;
    private Image buttonImage;
    private Button[] arrayButtons;

    private void Start()
    {
        arrayButtons = colorButtons.GetComponentsInChildren<Button>();
        foreach (Button button in arrayButtons)
        {
            button.onClick.AddListener(() => ChangeColor(button));
        }
    }

    void ChangeColor(Button button)
    {
        buttonImage = button.GetComponent<Image>();
        airplansArray = airplans.GetComponentsInChildren<MeshRenderer>();
        airplansArray[0].material.color = buttonImage.color;
    }
}