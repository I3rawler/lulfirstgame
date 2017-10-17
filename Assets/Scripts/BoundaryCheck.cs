using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryCheck : MonoBehaviour {

	void Update ()
	{
		// X axis
		if (transform.position.x <= -8.3f) {
			transform.position = new Vector2(-8.3f, transform.position.y);
		} else if (transform.position.x >= 8.3f) {
			transform.position = new Vector2(8.3f, transform.position.y);
		}

		// Y axis
		if (transform.position.y <= -4.7f) {
			transform.position = new Vector2(transform.position.x, -4.7f);
		} else if (transform.position.y >= 4.7f) {
			transform.position = new Vector2(transform.position.x, 4.7f);
		}
	}

}
