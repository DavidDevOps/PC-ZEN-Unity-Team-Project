using UnityEngine;
using System.Collections;

public class Monster_Status : MonoBehaviour {

	public int Hp;
	public int Damage;
	public int Gold;
	public int Exp;
	public AudioClip hit;
	public AudioClip death;
	public int Level;

	// Use this for initialization
	void Start () {
		Level = Random.Range (1,15);
		switch(Level)
		{
			case 1:
				Hp = 30;
				Damage = 7;
				Gold = Random.Range(5,12);
				Exp = 15;
				break;
			case 2:
				Hp = 45;
				Damage = 10;
				Gold = Random.Range(7,18);
				Exp = 19;
				break;
			case 3:
				Hp = 60;
				Damage = 13;
				Gold = Random.Range(11,24);
				Exp = 25;
				break;
			case 4:
				Hp = 75;
				Damage = 17;
				Gold = Random.Range(15,28);
				Exp = 32;
				break;
			case 5:
				Hp = 95;
				Damage = 22;
				Gold = Random.Range(18,34);
				Exp = 39;
				break;
			case 6:
				Hp = 115;
				Damage = 25;
				Gold = Random.Range(23,38);
				Exp = 47;
				break;
			case 7:
				Hp = 140;
				Damage = 29;
				Gold = Random.Range(28,45);
				Exp = 55;
				break;
			case 8:
				Hp = 165;
				Damage = 34;
				Gold = Random.Range(34,52);
				Exp = 63;
				break;
			case 9:
				Hp = 190;
				Damage = 38;
				Gold = Random.Range(40,60);
				Exp = 72;
				break;
			case 10:
				Hp = 220;
				Damage = 43;
				Gold = Random.Range(48,73);
				Exp = 82;
				break;
			case 11:
				Hp = 250;
				Damage = 48;
				Gold = Random.Range(53,80);
				Exp = 91;
				break;
			case 12:
				Hp = 285;
				Damage = 54;
				Gold = Random.Range(60,90);
				Exp = 101;
				break;
			case 13:
				Hp = 325;
				Damage = 60;
				Gold = Random.Range(71,104);
				Exp = 115;
				break;
			case 14:
				Hp = 360;
				Damage = 66;
				Gold = Random.Range(83,116);
				Exp = 126;
				break;
			case 15:
				Hp = 410;
				Damage = 75;
				Gold = Random.Range(95,130);
				Exp = 137;
				break;
			default:
				break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Hp <= 0)
		{
			AudioSource.PlayClipAtPoint(death,transform.position);
			Destroy(this.gameObject);
			MonsterSpawn.count --;
			CharacterStat._Money += Gold;
			CharacterStat._EXP += Exp;
		}
	}

	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Character" && CharacterAttact.attackswitch==true)
		{
			AudioSource.PlayClipAtPoint(hit,transform.position);
			Hp -= CharacterStat._ATK;
			CharacterAttact.attackswitch = false;
		}
	}
}
