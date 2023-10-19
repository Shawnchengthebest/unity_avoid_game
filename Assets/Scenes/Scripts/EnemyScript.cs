using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    Vector3 targetPosition;
    public float yPosition;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        randomPostionsGenerator();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        if (transform.position == targetPosition)
        {
            randomPostionsGenerator();
        }
    }

    void randomPostionsGenerator()
    {
        float randomX = Random.Range(minX, maxX);
        float randomZ = Random.Range(minZ, maxZ);
        targetPosition = new Vector3(randomX, yPosition, randomZ);
    }
}
