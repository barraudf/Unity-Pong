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

    public void SetNewVerticalVelocity(float y)
    {
        Vector2 vel = Vector2.zero;

        vel.y = y;

        if (rigidbody2D.velocity.x > 0)
            vel.x = GameController.Instance.HorizontalRatioCoefficient;
        else
            vel.x = -GameController.Instance.HorizontalRatioCoefficient;

        vel *= Speed;

        rigidbody2D.velocity = vel;
    }

    private void Launch()
    {
        Vector2 launch = Vector2.right;

        // 1-50 : ball launched to the left, 51-100 : ball launched to the right
        int rand = Random.Range(1, 100);
        if (rand < 51)
            launch.x = -launch.x;

        rigidbody2D.velocity = launch;
        SetNewVerticalVelocity(0f);

        audio.Play();
    }
}
