
using UnityEngine;
using System.Collections;


public class playermovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigidBody;
    private Vector3 change;
    private SpriteRenderer sr;
    public Animator animator;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        animator.SetFloat("speed", Mathf.Abs(change.x));
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if(change != Vector3.zero)
        {
            MoveCharacter();
        }
        Debug.Log(change);

        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput > 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }
    }
    void MoveCharacter()
    {
        myRigidBody.MovePosition(
            transform.position + change * speed * Time.deltaTime);
    }
}
