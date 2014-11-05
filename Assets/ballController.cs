using UnityEngine;
using System.Collections;

public class ballController : MonoBehaviour {
	public float speed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate(Vector3.down * speed * Time.deltaTime);
		} 
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate(Vector3.up * speed * Time.deltaTime);
		}

		
	}
}
