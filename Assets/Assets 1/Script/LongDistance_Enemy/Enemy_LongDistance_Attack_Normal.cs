using UnityEngine;
using System.Collections;
/// <summary>
/// E////////////////////////////////몬스터의 원거리 공격 스크립트/// </summary>
public class Enemy_LongDistance_Attack_Normal : MonoBehaviour {
	
	public GameObject character;
	public GameObject attack;
	static public bool switc = true;
	static public int look; //1은 왼쪽
	public static int damage; //데미지
	public GameObject left;
	public GameObject right;

	void Awake()
	{
		character = GameObject.Find ("Character");
		StartCoroutine (ta(0.0f));
	}

	void Update()
	{

	}

	IEnumerator ta(float wait)
	{
		switc = true;
		if (character.transform.position.z+1 < transform.position.z) {
		}
		else if (character.transform.position.z-1 > transform.position.z && switc==true) {
		}
		else if (character.transform.position.x > transform.position.x && switc==true) {
			if(character.transform.position.x - transform.position.x < 5 && switc==true)
			{
				Enemy_Move.swit=0;
				look = 0;
				Instantiate(attack,right.transform.position,Quaternion.identity);
				switc = false;
			}
		}
		else if (character.transform.position.x < transform.position.x && switc==true) {
			if(transform.position.x - character.transform.position.x < 5 && switc==true)
			{
				Enemy_Move.swit=0;
				look = 1;
				Instantiate(attack,left.transform.position,Quaternion.identity);
				switc = false;
			}
		};
		Enemy_Move.swit = 1;
		yield return new WaitForSeconds(wait);
		StartCoroutine (ta (1.5f));
	}
}