using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    bool touched = false;
    public float fallrate;
    Vector3 startingScale;
    public int reappearTime =2;
    int counter = 0;
    public bool reappear = true;

    private void Start()
    {
         startingScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
        if(reappear)
            InvokeRepeating("activeCheck", 0.0f, 4.0f);
    }

    void OnCollisionEnter(Collision col)
    {
        touched = true;
    }
    private void Update()
    {
        if(touched==true)
        {
            transform.localScale -= new Vector3(0, fallrate, 0);
        }
        if(transform.localScale.y<=0)
        {
            touched = false;
            transform.localScale = startingScale;
            gameObject.SetActive(false);
        }
    }
    private void activeCheck()
    {
        if (gameObject.activeSelf == false)
        {
            print("this happened");
            counter++;
        }
        if (counter > reappearTime)
        {
            counter = 0;
            gameObject.SetActive(true);
        }
    }
}
