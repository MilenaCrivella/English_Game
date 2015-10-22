using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class PaintWall : MonoBehaviour {

	public GameObject ChooseColor2;
    public GameObject color1; 


	void OnMouseDown()
	{
        if (this.gameObject.name == "Brush")
        {
            ChooseColor2.SetActive(true);
            color1.SetActive(true);

        }
		if (this.gameObject.name == "bluee") 
		{
			Debug.Log ("ooi");
			//ChooseColor2.SetActive (false);
            //color1.SetActive(false);
		}
	}
}
