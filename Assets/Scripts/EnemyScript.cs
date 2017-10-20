using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour {

	public float speed;
	public Transform player;
	private Rigidbody2D rb2d;

    public Sprite mySprite;

    void Start ()
	{
		rb2d = GetComponent<Rigidbody2D> ();

        
    }
	
	void FixedUpdate () 
	{
		var playerpos = GameObject.FindWithTag ("Player").transform.position;		

		float z = Mathf.Atan2 ((playerpos.y - transform.position.y), 
			          (playerpos.x - transform.position.x)) *
		          Mathf.Rad2Deg - 90;

		transform.eulerAngles = new Vector3 (0, 0, z);

<<<<<<< HEAD
		rb2d.AddForce (gameObject.transform.up * speed);

        /*if (GameObject.FindWithTag("Player") == null) {

            return;
        }*/
	}
=======
        rb2d.AddForce(gameObject.transform.up * speed);
    }
>>>>>>> 9079f00df2d64b438f3036f41fc5714b87a1d6d0

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "Bullet") 
		{


            // Destroy (gameObject);
            GetComponent<SpriteRenderer>().sprite = mySprite;
            // this.gameObject.layer = -1;
            

            Destroy(rb2d);
            Destroy(GetComponent<BoxCollider2D>());
            Destroy(GetComponent<EnemyScript>());


            
        }



    }
}
