using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	public AudioSource carSound;
	// Use this for initialization
	void Start () {
		carSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
