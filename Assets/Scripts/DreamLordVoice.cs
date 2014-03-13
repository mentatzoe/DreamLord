using UnityEngine;
using System.Collections;

public class DreamLordVoice : MonoBehaviour {
	public AudioClip[] clips = new AudioClip[23];
	private int rand;
	private int flip = 0;
	private AudioSource[] audioSources = new AudioSource[23];
	private bool running = false;
	public int delay = 60;
	private int storage =0;

	// Use this for initialization
	void Start () {
		storage = delay;
		int i = 0;
		while (i < 23) {
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
		rand= Random.Range (0,22);
		if (rand==flip){
			rand=Random.Range (0,22);
		}
		flip=rand;
		audioSources[flip].clip = clips[flip];
		audioSources[flip].Play();		
		delay = storage;
		//	if (flip==17){
		//		flip=0;
		//	}
	}else{
		delay--;
	}

	}
}
