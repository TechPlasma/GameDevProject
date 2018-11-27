using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliding : MonoBehaviour {
    //the speed at which the block moves in each direction
    public float xspeed, zspeed;
    //max distance from starting pos before the block turns around
    public float xdistance, zdistance;
    //tracks which x and z direction the block is currently moving
    public bool xdir, zdir;
    //the ancher point upon which the block starts and moves
    //in current implementation will always be the center of the blocks back and forth movement
    Vector3 startingpos;
    // Use this for initialization
    void Start()
    {
        startingpos = this.gameObject.gameObject.transform.position;

    }

    // Update is called once per frame
    //moves the block and checks if its gone past distance
    //if it has gone past distance turns it around
    void Update()
    {
        xslide();
        zslide();
    }
    void xslide()
    {
        if (xdir)
        {
            this.gameObject.gameObject.transform.position += new Vector3(xspeed, 0, 0);
        }
        else
            this.gameObject.gameObject.transform.position -= new Vector3(xspeed, 0, 0);
        if (this.gameObject.gameObject.transform.position.x >= startingpos.x + xdistance)
        {
            xdir = !xdir;
        }
        else if (this.gameObject.gameObject.transform.position.x <= startingpos.x - xdistance)
        {
            xdir = !xdir;
        }
    }
    void zslide()
    {
        if (zdir)
        {
            this.gameObject.gameObject.transform.position += new Vector3(0, 0, zspeed);
        }
        else
            this.gameObject.gameObject.transform.position -= new Vector3(0, 0, zspeed);
        if (this.gameObject.gameObject.transform.position.z >= startingpos.z + zdistance)
        {
            zdir = !zdir;
        }
        else if (this.gameObject.gameObject.transform.position.z <= startingpos.z - zdistance)
        {
            zdir = !zdir;
        }
    }
}
