using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour 
{

	private Vector3 		m_currentVelocity;

	private	bool			m_gameStarted = false;
	void Start () 
	{
		Application.targetFrameRate = 60;
		//m_currentVelocity += new Vector3( 
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
			}

			Jump();
		}
	}

	void FixedUpdate()
	{
		//gameObject.transform.position += m_currentVelocity;
	}

	void Jump()
	{
		rigidbody2D.velocity = new Vector2(0, 40);
		//rigidbody2D.AddForce( new Vector2(0, 100) );
	}
}
