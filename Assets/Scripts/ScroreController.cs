using UnityEngine;
using System.Collections;

public class ScroreController : MonoBehaviour
{
    public GameController.Players Player;

    public bool characterInQuicksand;
    void OnTriggerEnter2D(Collider2D other)
    {
        GameController.Instance.Score(Player);
    }
}
