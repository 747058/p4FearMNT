using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGoesFoward : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 3f;
    private float timer;

    void Start()
    {
        timer = lifetime;
    }

    void Update()
    {
        // Move the bullet forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Reduce the remaining lifetime
        timer -= Time.deltaTime;

        // Destroy the bullet after the specified lifetime
        if (timer <= 0f)
        {
            Destroy(gameObject);
        }
    }

}
