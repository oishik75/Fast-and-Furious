using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

	public float carSpeed; 
	Vector3 position;
	public float clampPos = 2.7f;
	UIManager ui;
	public AudioManager am;
	// Use this for initialization
	void Start () {
		position = transform.position;
		ui = GameObject.Find ("UIManager").GetComponent<UIManager> ();
		am.carSound.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;
		position.x = Mathf.Clamp (position.x,-clampPos,clampPos);
		transform.position = position;
	
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy Car") {
			Destroy (gameObject);
			am.carSound.Stop();
			ui.GameOver();
		}
	}
}
