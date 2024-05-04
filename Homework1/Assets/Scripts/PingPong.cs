using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PingPong : MonoBehaviour
{
    public float TargetTime;
    private float currentTime;
    private Vector3 pointStart;
    private Vector3 pointEnd;
    void Start()
    {
        pointStart = transform.position;
        // Генерация случайной конечной точки в трехмерном пространстве
        pointEnd = new Vector3(
            Random.Range(transform.position.x, transform.position.x + 10.0f),
            Random.Range(transform.position.y, transform.position.y + 10.0f),
            Random.Range(transform.position.z, transform.position.z + 10.0f)
        );
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        var normTime = currentTime / TargetTime;
        transform.position = Vector3.Lerp(pointStart, pointEnd, Mathf.PingPong(normTime, 1.0f));
    }
}
