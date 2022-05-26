using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProjectileProperties : MonoBehaviour
{
    public float magnetStrength = 7f;
	public int magnetDirection = 1;
	public int negativeDirection = -1;
	public bool loseMagnet = true;
	private Transform trans;
	private Rigidbody2D thisRb;
	private Transform magnetTrans;
	private Transform negativeTrans;
	private bool magnetInZone;
	private bool negativeInZone;
	private bool targetHit;
	void Awake()
	{
		trans = transform;
		thisRb = trans.GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		if (magnetInZone)
		{
			Vector2 directionToMagnet = magnetTrans.position - trans.position;
			float distance = Vector2.Distance(magnetTrans.position, trans.position);
			float magnetDistanceStrength = (3f / distance) * magnetStrength;
			thisRb.AddForce(magnetDistanceStrength * (directionToMagnet * magnetDirection));
		}
		else if (negativeInZone)
		{
			Vector2 directionToMagnet = negativeTrans.position - trans.position;
			float distance = Vector2.Distance(negativeTrans.position, trans.position);
			float magnetDistanceStrength = (4f / distance) * magnetStrength;
			thisRb.AddForce(magnetDistanceStrength * (directionToMagnet * negativeDirection));
		}
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "magnet")
		{
			magnetTrans = other.transform;
			magnetInZone = true;
		}
		else if (other.tag == "negative")
		{
			negativeTrans = other.transform;
			negativeInZone = true;
		}
		else if (other.tag == "target")
		{
			Destroy(gameObject);
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
	void OnTriggerExit2D (Collider2D other)
	{
		if (other.tag == "magnet" && loseMagnet)
		{
			magnetInZone = false;
		}
		else if (other.tag == "negative" && loseMagnet)
		{
			negativeInZone = false;
		}
	}
}
