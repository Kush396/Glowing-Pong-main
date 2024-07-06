using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
   public BallMovement ballMovement;
   public ScoreManager scoreManager;
    //public float launchDelay = 1.0f;

    private void Bounce(Collision2D collision)
   {
    Vector3 ballPosition = transform.position;
    Vector3 racketPosition = collision.transform.position;
    float racketHeight = collision.collider.bounds.size.y;

    float positionX;
    if(collision.gameObject.name == "Player 1")
    {
        positionX = 1;
    }
    else
    {
        positionX = -1;
    }

    float positionY = (ballPosition.y - racketPosition.y) / racketHeight;

    ballMovement.IncreaseHitCounter();
    ballMovement.MoveBall(new Vector2(positionX, positionY));
   }
   private void OnCollisionEnter2D(Collision2D collision)
   {
        if(collision.gameObject.name == "Player 1" || collision.gameObject.name == "Player 2")
        {
            Bounce(collision);
        }
        else if(collision.gameObject.name == "Right Border")
        {
            scoreManager.Player1Goal();
            ballMovement.player1Start = false;
            StartCoroutine(ballMovement.Launch());
            // StartCoroutine(DelayedLaunch());
        }
        else if(collision.gameObject.name == "Left Border")
        {
            scoreManager.Player2Goal();
            ballMovement.player1Start = true;
            StartCoroutine(ballMovement.Launch());
            //StartCoroutine(DelayedLaunch());
        }

   }

    /*IEnumerator DelayedLaunch()
    {
        yield return new WaitForSeconds(launchDelay); // Adjust the delay time here

        // Now, launch the ball
        StartCoroutine(ballMovement.Launch());
    }*/
}
