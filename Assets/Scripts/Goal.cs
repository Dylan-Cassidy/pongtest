using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    //Ball ball = new Ball();
    [SerializeField]
    private Ball ball;
    public enum GoalNumber { Goal1, Goal2 };
    public GoalNumber goalNumber = GoalNumber.Goal1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (goalNumber == GoalNumber.Goal1)
        {
            Debug.Log("P2 Score");
            ball.xSpeed = -10;
            ball.gameStart();
        }

        if (goalNumber == GoalNumber.Goal2)
        {
            Debug.Log("P1 Score");
            ball.xSpeed = 10;
            ball.gameStart();
        }
    }
}
