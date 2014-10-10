using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : Singleton<GameController>
{
    public enum Players { LeftPlayer, RightPlayer };

    public float GameSpeedCoefficient = 1.0f;

    private int _LeftPlayerScore = 0;
    private int _RightPlayerScore = 0;

    [HideInInspector]
    public BallController BallController;

    /// <summary>
    /// Everything (position, speed) will be scalled horizontally based on the screen resolution ratio.
    /// The ball takes the same time to travel from left to right, be it on a 4/3 screen or on a 16/9 one.
    /// </summary>
    public float HorizontalRatioCoefficient
    {
        get { return _HorizontalRatioCoefficient; }
    }

    private Text _LeftScoreText;
    private Text _RightScoreText;
    private float _HorizontalRatioCoefficient;

    void Awake()
    {
        _HorizontalRatioCoefficient = Camera.main.aspect / ((float)4 / 3);

        GameObject ballGO = (GameObject)GameObject.Find("Ball");
        BallController = ballGO.GetComponent<BallController>();

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
        BallController.ResetPositionAndDirection();
    }

    protected GameController() { } // guarantee this will be always a singleton only - can't use the constructor
}
