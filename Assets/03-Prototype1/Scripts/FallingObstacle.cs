using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObstacle : MonoBehaviour
{
    public float fallSpeed = 5f;
    private bool hasHitPlayer = false;

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
        if (!hasHitPlayer && other.CompareTag("Player"))
        {
            UI uiScript = FindObjectOfType<UI>();
            uiScript.DecreaseLives();

            hasHitPlayer = true;
            Destroy(gameObject);
        }
    }
}
