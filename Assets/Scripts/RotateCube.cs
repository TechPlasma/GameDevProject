using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour {

	public float speedY;
	public float speedX;
    public float speedZ;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (speedX, speedY, speedZ); //rotate on X,Y axis
	}
}
