﻿using UnityEngine;
using System.Collections;

public class BackgroundTiler : MonoBehaviour 
{
	public GameObject 	tiles;
	public tk2dSprite 	tile0;
	public tk2dSprite 	tile1;
	public Vector3		scrollingSpeed;

	private Vector3 m_startingPoint;
	private float m_tilingPoint;

	// Use this for initialization
	void Start () 
	{
		Vector3 tilePos1 = tile0.gameObject.transform.position + (new Vector3(tile0.GetBounds().extents.x, 0, 0) * 2.0f);
		tile1.gameObject.transform.position = tilePos1;

		m_startingPoint = tiles.gameObject.transform.position;
		m_tilingPoint = -1.0f * tile0.GetBounds().extents.x * 2.0f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		tiles.gameObject.transform.position += scrollingSpeed * Time.deltaTime;
		if ( tiles.gameObject.transform.position.x <= m_tilingPoint )
		{
			tiles.gameObject.transform.position = m_startingPoint;
		}
	}
}
