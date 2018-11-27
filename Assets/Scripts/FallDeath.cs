using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDeath : MonoBehaviour {

	public GameObject startingPrefab;
	public GameObject character;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -2) {
			gameObject.transform.position = startingPrefab.transform.position;
			character.gameObject.transform.position = startingPrefab.transform.position;
		}
	}
}
