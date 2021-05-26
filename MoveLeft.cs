using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 10;
    private PlayerControlleer playerControlleerScript;
    private float leftBound = -100;
    // Start is called before the first frame update
    private void Start()
    {
        playerControlleerScript = GameObject.Find("Player").GetComponent<PlayerControlleer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControlleerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        if (playerControlleerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
    /* I only start learn programming at Unity Learn course, and git*/


}
