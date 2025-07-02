using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float intervalMin = 0.5f;
    [SerializeField] float intervalMax = 3f;

    Transform target;

    float interval;
    float spawnTime;

    void Awake()
    {
        interval = Random.Range(intervalMin, intervalMax);
        spawnTime = 0f;

        target = FindObjectOfType<Player>().transform;
    }

    void Update()
    {
        spawnTime += Time.deltaTime;

        if (spawnTime >= interval)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);

            interval = Random.Range(intervalMin, intervalMax);
            spawnTime = 0;
        }
    }
}
