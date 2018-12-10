using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour {

    public Text livesText;
    public Text disksText;

    void Update () {
        livesText.text = "Lives: " + DontDestroy.numLives;
        disksText.text = "" + DontDestroy.numDisks;
	}
}
