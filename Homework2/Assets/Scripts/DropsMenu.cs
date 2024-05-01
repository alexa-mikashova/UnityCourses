using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropsMenu : MonoBehaviour
{
    public Text text;
    public Dropdown drops;

    private void Start()
    {
        drops.onValueChanged.AddListener((int value) =>
        {
            switch (value)
            {
                case 0:
                    text.text = "Option A";
                    break;
                case 1:
                    text.text = "Option B";
                    break;
                case 2:
                    text.text = "Option C";
                    break;
                case 3:
                    text.text = "Option D";
                    break;
            }
        });
    }
}
