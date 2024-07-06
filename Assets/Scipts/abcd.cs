using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abcd : MonoBehaviour
{
    public Rigidbody2D rb;

    private void Start()
    {
        Time.timeScale = 1.7f;
    }

    private void Update()
    {
        rb.velocity= rb.velocity.normalized;
        rb.velocity = rb.velocity * 5f;
    }
}
