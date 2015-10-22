using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class PaintWall : MonoBehaviour {

	public GameObject ChooseColor2;


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
			camera.backgroundColor = Color.blue;
		}
	}
}
