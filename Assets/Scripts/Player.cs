using UnityEngine;
using System.Collections;

public class Player : Singleton<Player> 
{
	public Transform 		topBoundary;

	private Vector3 		m_currentVelocity;
	
	private	bool			m_gameStarted = false;

	void Start () 
	{
		rigidbody2D.gravityScale = 0.0f;
	}
	
	void Update ()
	{
		if ( Input.GetMouseButtonUp(0) )
		{
			if ( !m_gameStarted )
			{
				m_gameStarted = true;
				rigidbody2D.gravityScale = 0.35f;
				GameManager.GetInstance().StartGame();
			}
			
			Jump();
		}
	}
	
	void Jump()
	{
		if ( topBoundary.position.y > gameObject.transform.position.y )
		{
			if ( rigidbody2D )
			{
				rigidbody2D.velocity = new Vector2(0, 40);
			}
		}
	}
	
	void OnTriggerEnter2D( Collider2D collider )
	{
		Die();
		GameManager.GetInstance().GameOver();
	}

	void Die()
	{
		Destroy (rigidbody2D);
	}
}
