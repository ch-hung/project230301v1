using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumFall : MonoBehaviour
{
    private float movementSpeed;
    private float movementAccelerate;

    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 0;
        movementAccelerate = 9.8f;
    }

    // Update is called once per frame
    void Update()
    {
        movementSpeed += movementAccelerate * Time.deltaTime;
        transform.position += Vector3.down * movementSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        movementAccelerate = 0;
        movementSpeed = 0;
    }
}
