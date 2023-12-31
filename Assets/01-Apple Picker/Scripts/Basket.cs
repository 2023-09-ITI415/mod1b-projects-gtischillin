using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Basket : MonoBehaviour
{
[Header("Set Dynamically")]
    public Text scoreGT;             

    void Start() {
    // Find a reference to the ScoreCounter
    GameObject scoreGO = GameObject.Find("ScoreCounter");

    // Get the Text Component of that GameObject
    scoreGT = scoreGO.GetComponent<Text>();

    // Set the starting number of points to "0"
    scoreGT.text = "0";
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
            // Parse the text of the scoreGT in
        int score = int.Parse(scoreGT.text);

        // Add points for catching the apple
        score += 100;

        // Convert the score back to a string
        scoreGT.text = score.ToString();
        if (score > HighScore.score) {
                HighScore.score = score;
            }
        }
    }
}