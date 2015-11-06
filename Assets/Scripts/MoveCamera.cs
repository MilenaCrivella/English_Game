using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	private bool isMov = false;

    void OnMouseDown()
    { 
		Debug.Log ("OI, MILENA!");
		isMov = true;
    }

	void Update() {
		if (isMov) {
			Camera.main.transform.position = new Vector3(
				Mathf.Lerp(Camera.main.transform.position.x, 20f, 5f * Time.deltaTime),
				Camera.main.transform.position.y, Camera.main.transform.position.z);
		}
	}
}
