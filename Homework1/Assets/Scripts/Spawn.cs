using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private GameObject prefab;
    public GameObject[] prefabs;
    private GameObject instance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (prefabs.Length == 0)
            {
                Debug.LogError("Prefab is NULL!!");
                return;
            }

            if (instance != null)
            {
                Destroy(instance);
            }

            GameObject prefabToSpawn = prefabs[Random.Range(0, prefabs.Length)];
            var rotation = Quaternion.identity;
            var position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
            instance = Instantiate(prefabToSpawn, position, rotation);
        }
    }
}
