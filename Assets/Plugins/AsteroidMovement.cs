using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    private Vector3 dir = new Vector3(100, 0, 0);
    public float movementSpeed = 5.0f;
    public float clockwise = 1000.0f;
    public float counterClockwise = -5.0f;


    void Start()
    {

    }

    void Update()
    {
        Destroy(gameObject, 3);
        transform.position += transform.right * Time.deltaTime * movementSpeed;
    }
}
