using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update () {
        // Get the current screen position of the mouse
        Vector3 mousePos2D = Input.mousePosition;
        // The Camera's z position sets how far to mouse the mouse into 3D
        mousePos2D.z = -Camera.main.transform.position.z;
        // Convert the point from 2D screen space into the 3D world space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        // Move the x position of this Basket to x position of mouse pointer
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;

        }
    void OnCollisionEnter(Collision coll) {  
        // Find out what hit this basket
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple") {   
            Destroy(collidedWith);
            }
    }
}