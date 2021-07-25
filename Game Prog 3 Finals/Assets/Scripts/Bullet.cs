using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

	public float _moveSpeed = 100f;

	private Rigidbody2D _rb;
	private BallDrag _target;
	Vector2 _moveDirection;

	
	void Start()
	{
		_rb = GetComponent<Rigidbody2D>();
		_target = GameObject.FindObjectOfType<BallDrag>();
		_moveDirection = (_target.transform.position - transform.position).normalized * _moveSpeed;
		_rb.velocity = new Vector2(_moveDirection.x, _moveDirection.y);
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
