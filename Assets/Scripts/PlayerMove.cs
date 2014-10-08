using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f;

    void FixedUpdate()
    {
        Vector2 force = Vector2.up * Input.GetAxisRaw("Vertical") * speed *Time.deltaTime;
        transform.Translate(force);
    }
}
