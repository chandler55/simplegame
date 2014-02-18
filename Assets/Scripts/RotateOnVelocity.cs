using UnityEngine;
using System.Collections;

public class RotateOnVelocity : MonoBehaviour 
{

	public float smoothingTime = 0.3f;

	private float m_rotation = 0.0f;

	private float m_currentVelocity = 0.0f;

	void Start () 
	{
	
	}
	
	void Update () 
	{
		Debug.Log ( rigidbody2D.velocity );
		//m_rotation = rigidbody2D.velocity.y;

		m_rotation = Mathf.SmoothDampAngle( m_rotation, rigidbody2D.velocity.y, ref m_currentVelocity, smoothingTime );
		//Vector3.SmoothDamp( 
		transform.rotation = Quaternion.Euler( new Vector3( 0, 0, m_rotation ) );
	}
}
