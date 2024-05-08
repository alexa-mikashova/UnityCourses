using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AirplaneSelector : MonoBehaviour
{
    public GameObject airplans;
    public Button leftBtn;
    public Button rightBtn;
    private int currentIndexAirplane = 1;
    private Transform[] airplansArray;
    public void Start()
    {
        airplansArray = airplans.GetComponentsInChildren<Transform>(true);
        leftBtn.onClick.AddListener(() =>
        {
            ToggleAirplan(airplansArray.Length - 1, 1, -1);
        });

        rightBtn.onClick.AddListener(() =>
        {
            ToggleAirplan(1, airplansArray.Length - 1, 1);
        });
    }

    private void ToggleAirplan(int startIndex, int lastIndex, int arithmeticFlag) // начальная точка после сброса, конечная возможная точка, направление шага в большую или меньшую сторону
    {
        airplansArray[currentIndexAirplane].gameObject.SetActive(false);
        if (currentIndexAirplane == lastIndex)
        {
            currentIndexAirplane = startIndex;
        }
        else
        {
            currentIndexAirplane += arithmeticFlag;
        }

        airplansArray[currentIndexAirplane].gameObject.SetActive(true);
    }
}
