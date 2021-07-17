using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

	float moveSpeed = 50f;

	Rigidbody2D rb;

	BallDrag target;
	Vector2 moveDirection;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		target = GameObject.FindObjectOfType<BallDrag>();
		moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
		rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
		Destroy(gameObject, 3f);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name.Equals("Player"))
		{
			Debug.Log("Hit!");
			Destroy(gameObject);
		}
	}

}
