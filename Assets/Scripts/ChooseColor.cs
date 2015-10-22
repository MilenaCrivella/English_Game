using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class ChooseColor : MonoBehaviour {

    public GameObject Color; 

	void OnMouseDown()
	{
        if (this.gameObject.name == "Blue")
        {
            Debug.Log("Choose");
            Color.SetActive(false);
        }
	}
}
