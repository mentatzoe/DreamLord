using UnityEngine;
using System.Collections;

public class DreamLordVoice : MonoBehaviour {
	public AudioClip[] clips = new AudioClip[18];
	private int rand;
	private int flip = 0;
	private AudioSource[] audioSources = new AudioSource[18];
	private bool running = false;
	public int delay = 60;
	private int storage =0;

	// Use this for initialization
	void Start () {
		storage = delay;
		rand = Random.Range (0,9);
		int i = 0;
		while (i < 18) {
			GameObject child = new GameObject("audio");
			child.transform.parent = gameObject.transform;
			audioSources[i] = child.AddComponent("AudioSource") as AudioSource;
			i++;
		}
		running = true;
		audioSources[flip].clip = clips[flip];
		audioSources[flip].Play();		
	}
	
	// Update is called once per frame
	void Update () {
	if (audioSources[flip].isPlaying)
		return;
	
	if (delay==0){
		flip++;
		audioSources[flip].clip = clips[flip];
		audioSources[flip].Play();		
		delay = storage;
			if (flip==17){
				flip=0;
			}
	}else{
		delay--;
	}

	}
}
