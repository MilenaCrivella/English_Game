using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class PaintWall : MonoBehaviour {

	public GameObject ChooseColor2;
	public Camera CameraGame;

	void OnMouseDown()
	{
        if (this.gameObject.name == "Brush")
        {
            ChooseColor2.SetActive(true);

        }
		if (this.gameObject.name == "Blue") 
		{
			Debug.Log ("ooi");
			ChooseColor2.SetActive (false);
			CameraGame.backgroundColor = Color.blue;
		}
		if (this.gameObject.name == "Red") 
		{
			Debug.Log ("ooi");
			ChooseColor2.SetActive (false);
			CameraGame.backgroundColor = Color.red;
		}
		if (this.gameObject.name == "Purple") 
		{
			Debug.Log ("ooi");
			ChooseColor2.SetActive (false);
			CameraGame.backgroundColor = Color.magenta;
		}
	}
}
