using UnityEngine;
using System.Collections;

public class CameraGame : MonoBehaviour {

    void CameraMovement()
    {
        Camera.main.transform.position = new Vector2(Input.mousePosition.x, this.transform.position.y);
    }

    void Update()
    {
        CameraMovement();
    }
}
