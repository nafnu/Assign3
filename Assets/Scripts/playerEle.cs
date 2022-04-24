using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerEle : MonoBehaviour
{

    public float speed = 30f;
    public float jumpForce;

    Transform check;
    public Transform firstCheck;

    public static int points = 0;
    public static int life = 3;
    public static int maxScore = 10;
    public static int minLife = 1;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        check = firstCheck;

    }

    private void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "checkpoint")
        {
            check = co.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //jump
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        //gravity flip
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded())
        {
            GetComponent<Rigidbody2D>().gravityScale *= -1;
            transform.Rotate(0, 180, 180);//turn character
        }
        
        /*
        //gravity flip
        if (Input.GetKeyDown(KeyCode.S) && isGrounded()) //gravity to the down
        {
            Physics2D.gravity = new Vector2(0, -9.81f);
            transform.Rotate(0, 180, 180);//turn character

        }
        else if (Input.GetKeyDown(KeyCode.A) && isGrounded()) //gravity to the left
        {
            Physics2D.gravity = new Vector2(-9.81f, 0);
            transform.Rotate(0, 0, -90);//turn character

        }
        else if (Input.GetKeyDown(KeyCode.D) && isGrounded()) //gravity to the right
        {
            Physics2D.gravity = new Vector2(9.81f, 0);
            transform.Rotate(0, 0, 90);//turn character

        }
        else if (Input.GetKeyDown(KeyCode.W) && isGrounded()) //gravity to the up
        {
            Physics2D.gravity = new Vector2(0, 9.81f);
            transform.Rotate(0, 180, 180);//turn character

        }
        */

    }

    private void OnCollisionEnter2D(Collision2D co)
    {
        if (co.collider.name == "V")
        {
            //reset gravity, rotation, velocity, position to last check
            transform.rotation = Quaternion.identity;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().gravityScale =
                Mathf.Abs(GetComponent<Rigidbody2D>().gravityScale);
            transform.position = check.position;
            
            life -= 1;

         }
    }

    private void FixedUpdate()
    {
        /*
        float h = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
        */

        Vector2 newVelocity;
        newVelocity.x = Input.GetAxisRaw("Horizontal") * speed;
        newVelocity.y = rb.velocity.y;

        rb.velocity = newVelocity;

        //animation
        GetComponent<Animator>().SetInteger("X", (int)newVelocity.x);

    }

    public bool isGrounded()
    {
        //get boundry of collider
        Bounds bounds = GetComponent<Collider2D>().bounds;

        //calculate casting range
        float range = bounds.extents.y * 1.2f;

        //get vector position below collider using range and vector2.up so it will behave with gravity
        Vector2 v = bounds.center - transform.up * range;

        //draw linecast
        RaycastHit2D hit = Physics2D.Linecast(v, bounds.center);

        //did the line hit another collider, and not ourself?
        return (hit.collider.gameObject != gameObject);
    }
}
