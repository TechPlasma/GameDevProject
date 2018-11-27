using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

	public GameObject orbitPlatform; //object we orbit around
	public float orbitSpeed; //speed at which cubes orbit
	public Vector3 direction; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		OrbitAround (); //function to make orbitCubes orbit around orbitPlatform
	}

	void OrbitAround(){
		transform.RotateAround (orbitPlatform.transform.position, direction, orbitSpeed * Time.deltaTime);
	}
}
