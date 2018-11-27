using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappearing : MonoBehaviour {

	public int counter = 1;
	Color lerpedColor = Color.black;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("CubeDisappear", 0.0f, 4.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CubeDisappear()
	{
		counter++;
		if (counter % 2 == 1) {
			gameObject.SetActive (true);
		} else
			this.gameObject.SetActive(false);

	}
}
