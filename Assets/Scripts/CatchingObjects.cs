using UnityEngine;
using System.Collections;

public class CatchingObjects : MonoBehaviour {

    void OnMouseDrag()
    {
        Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = position;
    }

    void OnMouseUp()
    {
        this.transform.position = new Vector2(7.5f, -4);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name.Equals("Cobweb"))
        {
            Destroy(coll.gameObject);
        }
    }
}
