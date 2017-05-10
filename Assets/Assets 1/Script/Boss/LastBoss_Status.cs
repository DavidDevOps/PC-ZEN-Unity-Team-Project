using UnityEngine;
using System.Collections;

public class LastBoss_Status : MonoBehaviour {
	public AudioClip death;
	public AudioClip hit;
	static public int Boss_HP = 10000;
	static public int Boss_Damage_Min = 150;
	static public int Boss_Damage_Max = 250;

	void Update()
	{
		if(Boss_HP <= 0)
		{
			Destroy(this.gameObject);
			AudioSource.PlayClipAtPoint(death,transform.position);
		}
	}

	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Character" && CharacterAttact.attackswitch==true)
		{
			AudioSource.PlayClipAtPoint(hit,transform.position);
			Boss_HP -= CharacterStat._ATK;
			CharacterAttact.attackswitch = false;
		}
	}
}
