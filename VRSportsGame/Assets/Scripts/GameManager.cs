using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BallController ball;
    public Transform launchDirection;

    public float launchForce = 10f;

    void Start()
    {
        Invoke(nameof(StartRound), 1f);
    }

    void StartRound()
    {
        if (ball && launchDirection)
        {
            Vector3 dir = launchDirection.forward;
            ball.LaunchBall(dir, launchForce);
        }
    }
}