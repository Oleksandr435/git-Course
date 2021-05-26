using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlleer : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody playerRB;
    public float JumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isOnGround)
        {
            playerRB.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
        }
    }



}
