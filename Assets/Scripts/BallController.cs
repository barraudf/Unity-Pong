using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    public float Speed = 1.0f;
    public float LaunchDelay = 2.0f;

    void Start()
    {
        ResetPositionAndDirection();
    }

    public void ResetPositionAndDirection()
    {
        transform.position = Vector3.zero;
        rigidbody2D.velocity = Vector2.zero;
        Invoke("Launch", LaunchDelay);
    }

    private void Launch()
    {
        //Vector2 launch = ((Vector2)Random.onUnitSphere).normalized * Speed;
        Vector2 launch = Vector2.right * Speed;
        rigidbody2D.velocity = launch;
    }
}
