using UnityEngine;
using System.Collections;
public class Soundseamless : MonoBehaviour {
	public float bpm = 120.0F;
	public int numBeatsPerSegment = 128;
	public AudioClip[] clips = new AudioClip[11];
	private int rand;
	private double nextEventTime;
	private int flip = 0;
	private AudioSource[] audioSources = new AudioSource[11];
	private bool running = false;
	void Start() {
		rand = Random.Range (0,9);
		int i = 0;
		while (i < 11) {
			GameObject child = new GameObject("audio");
			child.transform.parent = gameObject.transform;
			audioSources[i] = child.AddComponent("AudioSource") as AudioSource;
			i++;
		}
		nextEventTime = AudioSettings.dspTime + 2.0F;
		running = true;
	}
	void Update() {
		if (!running)
			return;
		
		double time = AudioSettings.dspTime;
		if (time + 1.0F > nextEventTime) {
			if (rand==0){
				if (flip==0){
					audioSources[0].clip = clips[0];
					audioSources[0].PlayScheduled(nextEventTime);
				}
				if (flip==1){
					audioSources[1].clip = clips[1];
					audioSources[1].PlayScheduled(nextEventTime);
				}
				if (flip==2){
					audioSources[5].clip = clips[5];
					audioSources[5].PlayScheduled(nextEventTime);
				}	
				if (flip==3){
					audioSources[9].clip = clips[9];
					audioSources[9].PlayScheduled(nextEventTime);
				}
				if (flip==4){
					audioSources[10].clip = clips[10];
					audioSources[10].PlayScheduled(nextEventTime);
				}
			}
			if (rand==1){
				if (flip==0){
					audioSources[0].clip = clips[0];
					audioSources[0].PlayScheduled(nextEventTime);
				}
				if (flip==1){
					audioSources[2].clip = clips[2];
					audioSources[2].PlayScheduled(nextEventTime);
				}
				if (flip==2){
					audioSources[6].clip = clips[6];
					audioSources[6].PlayScheduled(nextEventTime);
				}	
				if (flip==3){
					audioSources[7].clip = clips[7];
					audioSources[7].PlayScheduled(nextEventTime);
				}
				if (flip==4){
					audioSources[10].clip = clips[10];
					audioSources[10].PlayScheduled(nextEventTime);
				}
			}
			if (rand==2){
				if (flip==0){
					audioSources[0].clip = clips[0];
					audioSources[0].PlayScheduled(nextEventTime);
				}
				if (flip==1){
					audioSources[3].clip = clips[3];
					audioSources[3].PlayScheduled(nextEventTime);
				}
				if (flip==2){
					audioSources[4].clip = clips[4];
					audioSources[4].PlayScheduled(nextEventTime);
				}	
				if (flip==3){
					audioSources[8].clip = clips[8];
					audioSources[8].PlayScheduled(nextEventTime);
				}
				if (flip==4){
					audioSources[10].clip = clips[10];
					audioSources[10].PlayScheduled(nextEventTime);
				}
			}
			if (rand==3){
				if (flip==0){
					audioSources[0].clip = clips[0];
					audioSources[0].PlayScheduled(nextEventTime);
				}
				if (flip==1){
					audioSources[4].clip = clips[4];
					audioSources[4].PlayScheduled(nextEventTime);
				}
				if (flip==2){
					audioSources[9].clip = clips[9];
					audioSources[9].PlayScheduled(nextEventTime);
				}	
				if (flip==3){
					audioSources[2].clip = clips[2];
					audioSources[2].PlayScheduled(nextEventTime);
				}
				if (flip==4){
					audioSources[10].clip = clips[10];
					audioSources[10].PlayScheduled(nextEventTime);
				}
			}
			if (rand==4){
				if (flip==0){
					audioSources[0].clip = clips[0];
					audioSources[0].PlayScheduled(nextEventTime);
				}
				if (flip==1){
					audioSources[5].clip = clips[5];
					audioSources[5].PlayScheduled(nextEventTime);
				}
				if (flip==2){
					audioSources[7].clip = clips[7];
					audioSources[7].PlayScheduled(nextEventTime);
				}	
				if (flip==3){
					audioSources[3].clip = clips[3];
					audioSources[3].PlayScheduled(nextEventTime);
				}
				if (flip==4){
					audioSources[10].clip = clips[10];
					audioSources[10].PlayScheduled(nextEventTime);
				}
			}
			if (rand==5){
				if (flip==0){
					audioSources[0].clip = clips[0];
					audioSources[0].PlayScheduled(nextEventTime);
				}
				if (flip==1){
					audioSources[6].clip = clips[6];
					audioSources[6].PlayScheduled(nextEventTime);
				}
				if (flip==2){
					audioSources[8].clip = clips[8];
					audioSources[8].PlayScheduled(nextEventTime);
				}	
				if (flip==3){
					audioSources[1].clip = clips[1];
					audioSources[1].PlayScheduled(nextEventTime);
				}
				if (flip==4){
					audioSources[10].clip = clips[10];
					audioSources[10].PlayScheduled(nextEventTime);
				}
			}
			if (rand==6){
				if (flip==0){
					audioSources[0].clip = clips[0];
					audioSources[0].PlayScheduled(nextEventTime);
				}
				if (flip==1){
					audioSources[7].clip = clips[7];
					audioSources[7].PlayScheduled(nextEventTime);
				}
				if (flip==2){
					audioSources[3].clip = clips[3];
					audioSources[3].PlayScheduled(nextEventTime);
				}	
				if (flip==3){
					audioSources[5].clip = clips[5];
					audioSources[5].PlayScheduled(nextEventTime);
				}
				if (flip==4){
					audioSources[10].clip = clips[10];
					audioSources[10].PlayScheduled(nextEventTime);
				}
			}
			if (rand==7){
				if (flip==0){
					audioSources[0].clip = clips[0];
					audioSources[0].PlayScheduled(nextEventTime);
				}
				if (flip==1){
					audioSources[8].clip = clips[8];
					audioSources[8].PlayScheduled(nextEventTime);
				}
				if (flip==2){
					audioSources[1].clip = clips[1];
					audioSources[1].PlayScheduled(nextEventTime);
				}	
				if (flip==3){
					audioSources[6].clip = clips[6];
					audioSources[6].PlayScheduled(nextEventTime);
				}
				if (flip==4){
					audioSources[10].clip = clips[10];
					audioSources[10].PlayScheduled(nextEventTime);
				}
			}
			if (rand==8){
				if (flip==0){
					audioSources[0].clip = clips[0];
					audioSources[0].PlayScheduled(nextEventTime);
				}
				if (flip==1){
					audioSources[9].clip = clips[9];
					audioSources[9].PlayScheduled(nextEventTime);
				}
				if (flip==2){
					audioSources[2].clip = clips[2];
					audioSources[2].PlayScheduled(nextEventTime);
				}	
				if (flip==3){
					audioSources[4].clip = clips[4];
					audioSources[4].PlayScheduled(nextEventTime);
				}
				if (flip==4){
					audioSources[10].clip = clips[10];
					audioSources[10].PlayScheduled(nextEventTime);
				}
			}
			Debug.Log("Scheduled source " + flip + " to start at time " + nextEventTime);
			nextEventTime += 60.0F / bpm * numBeatsPerSegment;
			if (flip==4){
				flip=0;
			}
			flip = 1 + flip;
		}
	}
}