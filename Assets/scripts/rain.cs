using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    public GameObject rainDropPrefab;

    private float minX = 5.81f;
    private float maxX = 60.0f;
    private float minY = 1.83f;
    private float maxY = 13.06f;
    public float vel1 = 0.5f;
    public float vel2 = 1.0f;
    public float rate = 1.0f;

    private void Start()
    {
        InvokeRepeating("SpawnRainDrop", 0f, rate);
    }

    private void SpawnRainDrop()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Vector3 spawnPosition = new Vector3(randomX, randomY, 0);

        GameObject rainDrop = Instantiate(rainDropPrefab, spawnPosition, Quaternion.identity);

        Vector3 randomScale = Vector3.zero;

        float randomSize = Random.Range(0, 3);
        if (randomSize < 1.0f){
            randomScale = new Vector3(1, 1, 1);
        }
        else if (randomSize < 2.0f){
            randomScale = new Vector3(3, 3, 1);
        }
        else{
            randomScale = new Vector3(5, 5, 1);
        }

    rainDrop.transform.localScale = randomScale;
    Rigidbody2D rb = rainDrop.GetComponent<Rigidbody2D>();
    rb.velocity = new Vector2(-Random.Range(vel1, vel2), -Random.Range(vel1, vel2));  // Adjust the falling speed as needed

    }


}
