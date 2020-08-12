using UnityEngine;
using System.Collections;

public class EnemyCarController : MonoBehaviour {

	public float enemyCarSpeed = 15f;
	//Vector3 position;
	// Use this for initialization
	void Start () {
		//position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(0,1,0) * enemyCarSpeed * Time.deltaTime);
		//position.y -= enemyCarSpeed * Time.deltaTime;
		//transform.position = position;
	}
}
