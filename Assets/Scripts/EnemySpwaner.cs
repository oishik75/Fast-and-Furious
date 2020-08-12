using UnityEngine;
using System.Collections;

public class EnemySpwaner : MonoBehaviour {

	public GameObject[] enemyCars;
	int carNo;
	public float posRangeMax = 2.7f;
	public float spawnTime = 1f;
	float delayTimer;
	// Use this for initialization
	void Start () {
		delayTimer = spawnTime;
	
	}
	
	// Update is called once per frame
	void Update () {
		delayTimer -= Time.deltaTime;
		if (delayTimer <= 0) {
			Vector3 carPos = new Vector3 (Random.Range (-posRangeMax, posRangeMax), transform.position.y, transform.position.z);
			carNo = Random.Range (0,6);
			Instantiate (enemyCars[carNo], carPos, transform.rotation);
			delayTimer = spawnTime;
		}
	}
}
