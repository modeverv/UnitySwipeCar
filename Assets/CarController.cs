using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
	// 速度
	float speed = 0;
	// 初期場所
	Vector2 startPos;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		// スワイプの長さを求める
		detectMouse ();
		// 移動
		move ();
		// 減衰
		decay ();
	}

	/**
	 * スワイプの長さを求める
	 */
	void detectMouse ()
	{
		if (Input.GetMouseButtonDown (0)) {
			this.startPos = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp (0)) {
			Vector2 endPos = Input.mousePosition;
			float swipeLength = endPos.x - this.startPos.x;

			this.speed = swipeLength / 500.0f;
			play ();
		}
			
	}

	/**
	 * 移動
	 */ 
	void move ()
	{
		transform.Translate (this.speed, 0, 0);
	}

	/**
	 * 減衰
	 */ 
	void decay ()
	{
		this.speed *= 0.98f;
	}

	/**
	 * 音声再生
	 */ 
	void play ()
	{
		GetComponent<AudioSource> ().Play ();
	}
}
