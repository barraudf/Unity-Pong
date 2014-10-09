using UnityEngine;
using System.Collections;

public class PaddleCollisionManager : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            // X inversion is handled by unity physics. We just take care to change Y depending on where the ball collided the paddle
            Vector2 vel = col.gameObject.rigidbody2D.velocity;

            // We keep the speed of the ball (it is also accessible by a public property in BallController) to apply it after calculations
            float speed = vel.magnitude;

            // We only keep the direction
            vel.Normalize();

            // We change the vertical direction depending on the collision
            vel.y = VerticalBounceCoefficient(collider2D.bounds.extents.y, col.gameObject.transform.position.y, transform.position.y);

            // We get the new direction ...
            vel.Normalize();

            // ... and re-apply the original speed
            vel *= speed;

            col.gameObject.rigidbody2D.velocity = vel;

            audio.Play();
        }
    }

    protected float VerticalBounceCoefficient(float haflPaddleHeight, float yBall, float yPaddle)
    {
        // Coefficient goes from 1 at the top of the paddle to -1 at its bottom
        return (yBall - yPaddle) / haflPaddleHeight;
    }
}
