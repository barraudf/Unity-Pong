using UnityEngine;
using System.Collections;

public class ScroreController : MonoBehaviour
{
    public GameController.Players Player;

    void OnTriggerEnter2D(Collider2D other)
    {
        GameController.Instance.Score(Player);
    }
}
