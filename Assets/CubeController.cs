using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	// キューブの移動速度
	private float speed = -0.2f;

	// 消滅位置
	private float deadLine = -10;

	//地面の位置（課題）
	private float groundLevel = -3.0f;
	//（課題）

	public GameObject cubePrefab;

	private  AudioSource audioSource;

	public AudioClip audioClip ; 


	// Use this for initialization
	void Start () {
		
	}
	//Unityちゃんがキューブに当たった場合と当たらなかった場合の効果音（課題）
	void OnCollisionEnter2D(Collision2D col) {
		Debug.Log (col.gameObject.name);
		if (col.gameObject.tag == "cubePrefab" || col.gameObject.name == "ground") {
			Debug.Log (gameObject);
			audioSource = gameObject.GetComponent<AudioSource> ();
			audioSource.clip = audioClip;
			audioSource.Play (); 

		}
	}
	// Update is called once per frame
	void Update () {
		//キューブを移動させる
		transform.Translate (this.speed, 0, 0);


		//画面外に出たら破棄する
		if (transform.position.x < this .deadLine) {
			    Destroy (gameObject);
		
 	}
  }
}