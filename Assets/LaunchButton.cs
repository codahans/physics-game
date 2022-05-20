using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaunchButton : MonoBehaviour
{
    public Button myButton;
    private Rigidbody2D rb;
    private float thrust = 250f;
    void Start () 
    {
        rb = GetComponent<Rigidbody2D>();
        Button btn = myButton.GetComponent<Button>();
        btn.onClick.AddListener(LaunchBall);
    }
    void LaunchBall()
    {
        rb.AddForce(transform.right * thrust);
        rb.AddForce(transform.up * thrust);
    }
}

