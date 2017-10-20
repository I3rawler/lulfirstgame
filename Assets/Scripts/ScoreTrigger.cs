using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTrigger : MonoBehaviour
{
    public int scoreValue = 100;

    // Use this for initialization
    void Start ()
    {
		
	}

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Bullet")
        {
            //Debug.Log("Score!");

            // Increase the score by the enemy's score value.
            ScoreCounter.score += scoreValue;
        }
    }
}
