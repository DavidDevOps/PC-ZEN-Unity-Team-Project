using UnityEngine;
using System.Collections;

public class Boss_Thunder_Hit : MonoBehaviour { // 여기에 애니메이션 삽입

	float life = 0.8f;
	public AudioClip pla;
	public AudioClip pla2;
	void OnTriggerEnter(Collider other)
	{
		AudioSource.PlayClipAtPoint (pla,transform.position);
		if(other.name=="Character")
		{
			AudioSource.PlayClipAtPoint(pla2,transform.position);
			CharacterStat._HP -= Random.Range(LastBoss_Status.Boss_Damage_Min,LastBoss_Status.Boss_Damage_Max);
		}
	}
	
	void Update()
	{
		life -= Time.deltaTime;
		if (life < 0)
			Destroy (this.gameObject);
	}
}