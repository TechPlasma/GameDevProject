using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour {

    public string Stage;

    private void OnCollisionEnter(Collision collision)
    {
        if(Stage.Equals("Douglas")){
            SceneManager.LoadScene("DougLvl1");
        }
        if(Stage.Equals("Chase")){
            SceneManager.LoadScene("ChaseLevel1");
        }
        if(Stage.Equals("Saul")){
            SceneManager.LoadScene("SaulLevel1");
        }
        if(Stage.Equals("Beto")){
            SceneManager.LoadScene("BetoLevel1");
        }
    }
}
