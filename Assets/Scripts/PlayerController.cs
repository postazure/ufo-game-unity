using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;


	private int count;
	private Rigidbody2D rb2d;

	void Start() {
		rb2d = GetComponent<Rigidbody2D> ();
		count = 0;
		SetScoreText ();
		winText.text = "";
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");	
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb2d.AddForce (movement * speed);
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("PickUp")) {
			count++;
			SetScoreText ();
			other.gameObject.SetActive (false);
		}
	}

	void SetScoreText(){
		countText.text = "Score: " + count.ToString ();

		if (count >= 8) {
			winText.text = "You Win!";
		}
	}
}