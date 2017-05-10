using UnityEngine;
using System.Collections;

public class BGM_PLAY_VIllage : MonoBehaviour {

	public AudioSource bgm;
	public static bool swit = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(swit==false)
		{
			bgm.audio.Stop();
		}
	}

	void OnTriggerStay(Collider other)
	{
		CharacterMove.ground = 1;
		if(other.gameObject.name == "Character" && swit==false && test.swit == false)
		{
			BGM_PLAY_BOSS.swit = false;
			BGM_PLAY_STAGE.swit = false;
			bgm.audio.Play();
			swit = true;
		}
	}
}
