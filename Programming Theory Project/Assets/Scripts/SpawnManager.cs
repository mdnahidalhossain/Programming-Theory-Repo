using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject spawnObject;

    private float timeDelay = 1.0f;
    private float spawnTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnPosition", timeDelay, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SpawnPosition()
    {
        float posX = 22.0f;
        float posY = Random.Range(12.0f, 4.0f);
        float posZ = -0.79f;
        Vector3 tileSpawnPos = new Vector3(posX, posY, posZ);

        Instantiate(spawnObject, tileSpawnPos, spawnObject.transform.rotation);
    }

}
