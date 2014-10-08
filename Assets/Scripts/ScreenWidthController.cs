using UnityEngine;
using System.Collections;

public class ScreenWidthController : MonoBehaviour
{
	void Start ()
    {
        GameObject leftBound = GameObject.Find("Left");
        GameObject rightBound = GameObject.Find("Right");
        GameObject leftPaddle = GameObject.Find("LeftPaddle");
        GameObject rightPaddle = GameObject.Find("RightPaddle");

        float halfHeight = Camera.main.orthographicSize;
        float halfWidth = halfHeight * Camera.main.aspect + 0.5f;
        
        Vector3 newPosition = new Vector3(-halfWidth, 0, 0);
        leftBound.transform.position = newPosition;

        newPosition = new Vector3(halfWidth, 0, 0);
        rightBound.transform.position = newPosition;

        newPosition = new Vector3(-halfWidth + 1.5f, 0, 0);
        leftPaddle.transform.position = newPosition;

        newPosition = new Vector3(halfWidth - 1.5f, 0, 0);
        rightPaddle.transform.position = newPosition;
	}
}
