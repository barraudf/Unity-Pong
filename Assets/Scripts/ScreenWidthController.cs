using UnityEngine;
using System.Collections;

public class ScreenWidthController : MonoBehaviour
{
	void Start ()
    {
        GameObject left = GameObject.Find("Left");
        GameObject right = GameObject.Find("Right");

        float halfHeight = Camera.main.orthographicSize;
        float halfWidth = halfHeight * Camera.main.aspect + 0.5f;
        
        Vector3 newPosition = new Vector3(-halfWidth, 0, 0);
        left.transform.position = newPosition;

        newPosition = new Vector3(halfWidth, 0, 0);
        right.transform.position = newPosition;
	}
}
