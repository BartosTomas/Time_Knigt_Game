using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightScript : MonoBehaviour
{
    private Rigidbody2D rb;

    public float moveSpeed;
    public float acceleration;
    public float decceleration;
    public float velPower;
    public float frictionAmount;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        #region Run
        //input 
        float moveInput = Input.GetAxisRaw("Horizontal");

        //target speed in direction of input
        float targetSpeed = moveInput * moveSpeed;

        //actuall force needed to achive target speed
        float speedDif = targetSpeed - rb.velocity.x;

        //
        float accelRate = (Mathf.Abs(targetSpeed) > 0.01f) ? acceleration : decceleration;

        float movement = Mathf.Pow(Mathf.Abs(speedDif) * accelRate, velPower) * Mathf.Sign(speedDif);

        rb.AddForce(movement * Vector2.right);
        #endregion

        #region Jump
        
        #endregion
}
}