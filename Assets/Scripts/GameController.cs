using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : Singleton<GameController>
{
    public enum Players { LeftPlayer, RightPlayer };

    public float GameSpeedCoefficient = 1.0f;

    private int _LeftPlayerScore = 0;
    private int _RightPlayerScore = 0;

    private BallController _BallController;

    private Text _LeftScoreText;
    private Text _RightScoreText;

    void Start()
    {
        GameObject ballGO = (GameObject)GameObject.Find("Ball");
        _BallController = ballGO.GetComponent<BallController>();

        GameObject leftScoreGO = (GameObject)GameObject.Find("LeftScore");
        _LeftScoreText = leftScoreGO.GetComponent<Text>();

        GameObject RightScoreGO = (GameObject)GameObject.Find("RightScore");
        _RightScoreText = RightScoreGO.GetComponent<Text>();
    }

    public void Score(Players player)
    {
        if (player == Players.LeftPlayer)
        {
            _LeftPlayerScore++;
            _LeftScoreText.text = _LeftPlayerScore.ToString();
        }
        else
        {
            _RightPlayerScore++;
            _RightScoreText.text = _RightPlayerScore.ToString();
        }
        _BallController.ResetPositionAndDirection();
    }

    protected GameController() { } // guarantee this will be always a singleton only - can't use the constructor
}
