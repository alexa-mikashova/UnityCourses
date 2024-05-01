using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button buttonOne;
    public Button buttonTwo;
    public Button buttonDisable;
    public Text text;
    void Start()
    {

        buttonTwo.onClick.AddListener(() =>
        {
            text.gameObject.SetActive(true);
            text.text = "Two Clicked";
        });

        buttonDisable.onClick.AddListener(() =>
        {
            buttonOne.interactable = false;
            buttonTwo.interactable = false;
            buttonDisable.interactable = false;
        });
    }

}
