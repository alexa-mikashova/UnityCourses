using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class positionCameras : MonoBehaviour
{
    public Button upBtn;
    public Button downBtn;
    public Button leftBtn;
    public Button faceBtn;
    public GameObject cameraPosition;
    void Start()
    {
        upBtn.onClick.AddListener(() =>
        {
            cameraPosition.transform.position = new Vector3(0, 800, 1000);
            cameraPosition.transform.rotation = Quaternion.Euler(90, 0, 0);
        });

        downBtn.onClick.AddListener(() =>
        {
            cameraPosition.transform.position = new Vector3(0, -800, 1000);
            cameraPosition.transform.rotation = Quaternion.Euler(-90, 180, 0);
        });

        leftBtn.onClick.AddListener(() =>
        {
            cameraPosition.transform.position = new Vector3(800, 0, 1000);
            cameraPosition.transform.rotation = Quaternion.Euler(180, 90, 180);
        });

        faceBtn.onClick.AddListener(() =>
        {
            cameraPosition.transform.position = new Vector3(0, 0, 200);
            cameraPosition.transform.rotation = Quaternion.Euler(0, 0, 0);
        });
    }
}
