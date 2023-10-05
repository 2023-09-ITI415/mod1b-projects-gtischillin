using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObstacle : MonoBehaviour
{
    public float fallSpeed = 5f;

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
