using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    public GameObject sphere;
    public float speed = 6.0f;
    private Vector3 positionSphere;
    private Vector3 positionPoint;
    private bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        positionSphere = sphere.transform.position; // начальная точка
        positionPoint = new Vector3(Random.Range(positionSphere.x, positionSphere.x + 10.0f), 0, 0); // конечная точка
    }

    // Update is called once per frame
    void Update()
    {
        if (sphere.transform.position.x < positionPoint.x && !flag)
        {
            sphere.transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else if (sphere.transform.position.x > positionSphere.x)
        {
            flag = true;
            sphere.transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        else
        {
            flag = false;
        }
    }
}
