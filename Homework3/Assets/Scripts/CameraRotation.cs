using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float rotationSpeed = 10f; 
    public GameObject airplans;
    private Transform[] airplansArray;
    private Vector3 defaultPositionCamera;
    private Quaternion defaultRotationCamera;

    void Start()
    {
        airplansArray = airplans.GetComponentsInChildren<Transform>();

        defaultPositionCamera = transform.position;
        defaultRotationCamera = transform.rotation;
    }

    void Update()
    {
        // �������� �� �����
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                // ���������� ���� ��������
                float rotationX = touch.deltaPosition.x * rotationSpeed * Time.deltaTime;
                // ���������� �������� � ������
                transform.RotateAround(airplansArray[1].position, Vector3.up, -rotationX);
            } else if (touch.phase == TouchPhase.Ended)
            {
                // ���� ����� ������, �� ������� ������ �������� �����
                transform.position = defaultPositionCamera;
                transform.rotation = defaultRotationCamera;
            }
        }
    }
}
