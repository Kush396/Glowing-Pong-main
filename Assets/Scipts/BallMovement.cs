using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    //setting speed of the ball
    public float startSpeed;
    public float extraSpeed;
    public float maxEtraSpeed;
  
    public bool player1Start = true;

    private int hitCounter = 0;

    private Rigidbody2D rb;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        StartCoroutine(Launch());
    
    }
    private void RestartBall()
    {
        //rs.respawn();
        rb.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);
        //SceneManager.LoadScene(1);
    }


    public IEnumerator Launch(){
        //RestartBall();
        hitCounter = 0;
        yield return new WaitForSeconds(1);
        if(player1Start == true)
        {
            MoveBall(new Vector2(-1, 0));
        }
        else
        {
            MoveBall(new Vector2(1, 0));
        }
        
    }

    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;

        float ballSpeed = startSpeed + hitCounter*extraSpeed;

        rb.velocity = direction*ballSpeed; 
    }
    public void IncreaseHitCounter()
    {
        if(hitCounter* extraSpeed < maxEtraSpeed)
        {
            hitCounter++;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("paddle"))
        {
            rb.velocity = new Vector2(10f, rb.velocity.y);
        }

        if (collision.gameObject.CompareTag("PADDLE1"))
        {
            rb.velocity = new Vector2(-10f, rb.velocity.y);
        }
    }

}
