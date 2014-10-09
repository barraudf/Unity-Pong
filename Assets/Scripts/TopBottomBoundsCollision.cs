using UnityEngine;
using System.Collections;

public class TopBottomBoundsCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            audio.Play();
        }
    }
}
