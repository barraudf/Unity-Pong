using UnityEngine;
using System.Collections;

public class PaddleCollisionManager : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            // We change the vertical direction depending on the collision
            float coef = VerticalBounceCoefficient(collider2D.bounds.extents.y, col.gameObject.transform.position.y, transform.position.y);

            GameController.Instance.BallController.SetNewVerticalVelocity(coef);
            
            audio.Play();
        }
    }

    protected float VerticalBounceCoefficient(float haflPaddleHeight, float yBall, float yPaddle)
    {
        // Coefficient goes from 1 at the top of the paddle to -1 at its bottom
        return (yBall - yPaddle) / haflPaddleHeight;
    }
}
