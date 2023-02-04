using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 1f;
    public float leftLimit = -10f;
    public float rightLimit = 10f;

    private bool movingRight = true;

    void Update()
    {
        if (movingRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            if (transform.position.x > rightLimit)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            if (transform.position.x < leftLimit)
            {
                movingRight = true;
            }
        }
    }
}

//needs to be attached in the enemy prefab script for each of the enemies


