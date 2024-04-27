using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    public GameObject cybeScaler;
    public float scalerSpeed = 0.5f;
    private float newSide;
    // Start is called before the first frame update
    void Start()
    {
        newSide = Random.Range(0.5f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(newSide, newSide, newSide), Time.deltaTime * scalerSpeed);
    }
}
