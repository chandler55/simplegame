﻿using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour, IEventListener
{
	int m_score = 0;

	// Use this for initialization
	void Start () 
	{
		EventManager.Instance.AttachListener(this, "IncrementScore", HandleIncrementScore );
		EventManager.Instance.AttachListener(this, "GameOverEvent", HandleGameOverEvent );
	}

	void OnDisable()
	{
		if ( EventManager.Instance )
		{
			EventManager.Instance.DetachListener(this);
		}
	}

	// Update is called once per frame
	void Update ()
	{
	
	}

	void IncrementScore()
	{
		m_score++;
		tk2dTextMesh textMesh = gameObject.GetComponent<tk2dTextMesh>();
		if ( textMesh )
		{
			textMesh.text = m_score.ToString();
		}
	}

	bool HandleIncrementScore( IEvent evt )
	{
		IncrementScore();
		return false;
	}

	bool HandleGameOverEvent( IEvent evt )
	{
		EventManager.Instance.QueueEvent( new Events.ScoreEvent(m_score) );
		return false;
	}
}
