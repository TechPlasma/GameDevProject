using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour {

    public GameObject startingPrefab;
    public Text windowField;
    public string winText = "You completed Level ";
    public string level;
    public int secondsToDisplayText = 5;
    bool gotDisk = false;

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
            //TeleportToBeginning();
            BeginNextLevel();
        }
        
	}

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Finish")) {
            SetFinishText();
            if(gotDisk == false) //makes sure disk only counted once
            {
                DontDestroy.numDisks++;
                gotDisk = true;
            }

        }
    }

    void TeleportToBeginning() {
        gameObject.transform.position = startingPrefab.transform.position;
    }

    void BeginNextLevel(){
        DontDestroy.numLives += 5;
        Debug.Log("Inside NextLevel func");
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("DougLvl1")){
            SceneManager.LoadScene("DougLvl2");
            Debug.Log("Inside if statement");
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("DougLvl2"))
        {
            SceneManager.LoadScene("DougLvl3");
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("DougLvl3"))
        {
            SceneManager.LoadScene("Lobby");
        }

    }

    void SetFinishText() {
        windowField.text = "Level " + level + " Complete!";
        timeout = secondsToDisplayText;
        timer = Time.fixedDeltaTime;
    }
}
