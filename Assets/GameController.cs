using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject magnet;
    public GameObject magnetCollider;
    private Rigidbody2D magnetRb;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector2 mousePosition = Input.mousePosition;
            Vector2 instancePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Instantiate (magnet, instancePosition, Quaternion.identity);
            Instantiate (magnetCollider, instancePosition, Quaternion.identity);
        }
    }
}
