using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] GameObject platformTile;
    public GameObject platformHolder;
    Vector3 nextSpawnPoint;
    [SerializeField] float spawnDelay = 2.0f;
    public void SpawnPlatform()
    {
        if (platformHolder.transform.childCount <= 1)
        {
            int rand = Random.Range(1, 4);
            GameObject temp = Instantiate(platformTile, nextSpawnPoint, Quaternion.identity);
            temp.transform.SetParent(platformHolder.transform);
            nextSpawnPoint = temp.transform.GetChild(rand).transform.position;
        }
       /* if (spawnItems)
        {
            temp.GetComponent<PlatformTile>().SpawnObstacle();
        }*/
    }

    private void Start()
    {
        InvokeRepeating("SpawnPlatform", 0, spawnDelay);
    }
    private void Update()
    {

    }
}
