﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note : MonoBehaviour {
	public Transform target;
	public float speed;
	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "batang"){
			//Destroy (col.gameObject);
		}

	}
}
