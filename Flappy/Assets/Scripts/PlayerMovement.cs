using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float xForce = 2f;
    [SerializeField]
    private float yForce = 5f;
    private Rigidbody2D rb;
    public EndGame endGame;
    public bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
            return;
        rb.velocity = new Vector2(xForce, rb.velocity.y);
        
    }

    

    public void Jump()
    {
        if (isDead)
            return;
        rb.velocity = new Vector2(0, yForce);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "ScoreUp")
        {
            FindObjectOfType <Score> ().GetScoreCount();
        }
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
         Debug.Log("1");
        if (collision.gameObject.CompareTag("Pipe"))
        {
            print("2");
            isDead = true;
            FindObjectOfType <Score> ().OnDeath();
            
            //FindObjectOfType <EndGame> ().End();
            endGame.End();
        }
    } 

   
}
