using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject spawnObject;
    Vector3 tileSpawnPos = new Vector3(12.22f, 0.2895631f, 0);

    // Start is called before the first frame update
    void Start()
    {
        //spawnObject = GetComponent<GameObject>();

        InvokeRepeating("SpawnPosition", 1.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //SpawnPosition();
    }

    public void SpawnPosition()
    {
        Instantiate(spawnObject, tileSpawnPos, spawnObject.transform.rotation);
    }
}
