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
    }
}
