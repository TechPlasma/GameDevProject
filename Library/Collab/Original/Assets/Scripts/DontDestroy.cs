using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour {

    public static int numDisks = 0;
    public static int numLives = 5;

    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
            Destroy(this.gameObject); //if you're the second instance of a music object, destroy yourself
        if (SceneManager.GetActiveScene() != SceneManager.GetSceneByName("Lobby")){ //keep whatever music is playing except when in Lobby
            Debug.Log("Not equals Lobby");
            DontDestroyOnLoad(this.gameObject);
        }
        else{
            Debug.Log("Equals Lobby");
            for (int i = 0; i < objs.Length; i++){
                Destroy(objs[i]);
            }
        }

    }
}
