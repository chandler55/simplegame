using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public float jumpForce;
	void Start () 
	{
	
	}
	
	void Update () 
	{
		if ( transform.position.x > 400 )
		{
			transform.position -= new Vector3( 400, 0, 0 );
		}

		rigidbody2D.AddForce( new Vector2( 1000, 0 ) );
		if (Input.GetKeyDown(KeyCode.Z))
		{
			rigidbody2D.AddForce(new Vector2(0, jumpForce));
		}

	}

	void FixedUpdate()
	{
		Physics2D.IgnoreLayerCollision( LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Land"), rigidbody2D.velocity.y > 0 );
	}

	void OnCollisionEnter2D( Collision2D collision )
	{
		if ( gameObject.transform.position.y < collision.gameObject.transform.position.y )
		{
			Debug.Log ("test");
			collision.gameObject.collider2D.enabled= false;
		}

	}
}
