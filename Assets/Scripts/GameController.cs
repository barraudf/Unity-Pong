using UnityEngine;
using System.Collections;

public class GameController : Singleton<GameController>
{
    public enum Players { LeftPlayer, RightPlayer };

    public float GameSpeedCoefficient = 1.0f;

    private int _LeftPlayerScore = 0;
    private int _RightPlayer = 0;

    private BallController _BallController;

    void Start()
    {
        GameObject ballGO = (GameObject)GameObject.Find("Ball");
        _BallController = ballGO.GetComponent<BallController>();
    }

    public void Score(Players player)
    {
        if (player == Players.LeftPlayer)
            _LeftPlayerScore++;
        else
            _RightPlayer++;
        _BallController.ResetPositionAndDirection();
    }

    protected GameController() { } // guarantee this will be always a singleton only - can't use the constructor
}
