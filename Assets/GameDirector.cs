using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameDirector : MonoBehaviour
{

	GameObject car;
	GameObject flag;
	GameObject distance;

	// Use this for initialization
	void Start ()
	{
		this.car = GameObject.Find ("car");
		this.flag = GameObject.Find ("flag");
		this.distance = GameObject.Find ("Distance");
	}
	
	// Update is called once per frame
	void Update ()
	{
		float length = getLength ();
		if (length >= 0f) {
			setText ("to Goal," + length.ToString ("F2") + "m");
		} else {
			setText ("GameOver");
		}

	}

	float getLength ()
	{
		return this.flag.transform.position.x - this.car.transform.position.x;
	}

	void setText (String str)
	{
		this.distance.GetComponent<Text> ().text = str;
	}
}
