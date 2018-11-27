using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour {

    public GameObject startingPrefab;
    public Text windowField;
    public string winText = "You completed Level ";
    public string level;
    public int secondsToDisplayText = 10;

    private int timeout;
    private float timer;

	// Use this for initialization
	void Start () {
        timer = Time.fixedDeltaTime;
        timeout = -1;
        windowField.text = "";
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        timer += Time.fixedDeltaTime;


        if(timeout != -1 && timer >= timeout) {
            timeout = -1;
            windowField.text = "";
            TeleportToBeginning();
        }
        
	}

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Finish")) {
            SetFinishText();
        }
    }

    void TeleportToBeginning() {
        gameObject.transform.position = startingPrefab.transform.position;
    }

    void SetFinishText() {
        windowField.text = winText + level + "!";
        timeout = secondsToDisplayText;
        timer = Time.fixedDeltaTime;
    }
}
