using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour {

	public float Speed;
	static public int ground =1;
	float x;
	float z;
	public static bool swit = true;
	public Animator animation;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.RightArrow) && swit==true){
			transform.Translate(Vector3.right * Speed * Time.smoothDeltaTime);
			animation.SetFloat("Speed",1);
		}

		if(Input.GetKey(KeyCode.LeftArrow) && swit==true){
			transform.Translate(Vector3.left * Speed * Time.smoothDeltaTime);
			animation.SetFloat("Speed",1);
		}

		if(Input.GetKey(KeyCode.UpArrow) && swit==true){
			transform.Translate(Vector3.forward * Speed * Time.smoothDeltaTime);
			animation.SetFloat("Speed",1);
		}

		if(Input.GetKey(KeyCode.DownArrow) && swit==true){
			transform.Translate(Vector3.back * Speed * Time.smoothDeltaTime);
			animation.SetFloat("Speed",1);
		}

		if(Input.GetKeyUp(KeyCode.RightArrow)||Input.GetKeyUp(KeyCode.UpArrow)||
		   Input.GetKeyUp(KeyCode.LeftArrow)||Input.GetKeyUp(KeyCode.DownArrow))
		{
			animation.SetFloat("Speed",0);

		}

		switch(ground)
		{
			case 1:
				x = Mathf.Clamp(transform.position.x, 3.12f,21.3f);
				z = Mathf.Clamp(transform.position.z, -24f,-16f);
				transform.position = new Vector3 (x,transform.position.y,z);
				break;
			case 2:
				x = Mathf.Clamp(transform.position.x, -3.69f,46f);
				z = Mathf.Clamp(transform.position.z, 19.5f,28.5f);
				transform.position = new Vector3 (x,transform.position.y,z);
				break;
			case 3:
				x = Mathf.Clamp(transform.position.x, 1.59f,27.78f);
				z = Mathf.Clamp(transform.position.z, 61.9f,71.23f);
				transform.position = new Vector3 (x,transform.position.y,z);
				break;
			default:
				break;
		}
	}
}
