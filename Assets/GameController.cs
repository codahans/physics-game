using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Projectile;
    public GameObject magnet;
    public GameObject magnetCollider;
    public GameObject negative;
    public GameObject NegativeCollider;
    private Rigidbody2D magnetRb;
    void Update()
    {
        if (Projectile.activeSelf == false)
        {
            if (Input.GetKeyDown("e"))
            {
                Vector2 mousePosition = Input.mousePosition;
                Vector2 instancePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                Instantiate (magnet, instancePosition, Quaternion.identity);
                Instantiate (magnetCollider, instancePosition, Quaternion.identity);
            }
            if (Input.GetKeyDown("r"))
            {
                Vector2 mousePosition = Input.mousePosition;
                Vector2 instancePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                Instantiate (negative, instancePosition, Quaternion.identity);
                Instantiate (NegativeCollider, instancePosition, Quaternion.identity);
            }
        }
    }
}
