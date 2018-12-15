﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int damage = 1;
	public float speed;
	
	public GameObject effect;
	
	private void Update()
	{
		transform.Translate(Vector2.left * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D (Collider2D other) {
	
		if (other.CompareTag("Player")){
			Instantiate(effect, transform.position, Quaternion.identity);
			// player takes damage!
		    other.GetComponent<Player>().health -= damage;
		    Debug.Log(other.GetComponent<Player>().health);
		    Destroy(gameObject);
		}
	}
}
