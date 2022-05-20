using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    private Rigidbody2D rb;
    private float thrust = 250f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnMouseDown()
    {
        rb.AddForce(transform.right * thrust);
        rb.AddForce(transform.up * thrust);
    }
}
