using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public GameObject cylinder;
    public float rotationSpeed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cylinder.transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
    }
}
