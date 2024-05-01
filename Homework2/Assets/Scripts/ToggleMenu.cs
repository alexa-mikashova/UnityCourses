using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class OpenToggleMenu : MonoBehaviour
{
    public Text title;
    public ToggleGroup toggleGroup;
    public Toggle toggleFirst;
    public Toggle toggleSecond;
    public Toggle toggleThird;

    void Start()
    {
        toggleFirst.onValueChanged.AddListener((isChange) =>
        {
            title.text = "First";
        });

        toggleSecond.onValueChanged.AddListener((isChange) =>
        {
            title.text = "Second";
        });

        toggleThird.onValueChanged.AddListener((isChange) =>
        {
            title.text = "Third";
        });

        toggleFirst.group = toggleGroup;
        toggleSecond.group = toggleGroup;
        toggleThird.group = toggleGroup;
    }
}
