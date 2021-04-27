using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translateMovement : MonoBehaviour
{
    [Range(1, 2)]
    public int playerNum;
    public KeyCode[] keyCodes;
    Rigidbody2D rigidbody;
    public float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdateMovement();
    }

    public void UpdateMovement()
    {
        if (Input.GetKey(keyCodes[0]))
        {
            //rigidbody.velocity = new Vector2(rigidbody.velocity.x, moveSpeed);
            transform.rotation = Quaternion.Euler(0, 0, 180);
            transform.Translate(Vector2.up * -0.64f * Time.deltaTime);
            Debug.Log("Up");
        }
        else if (Input.GetKey(keyCodes[1]))
        {
            //rigidbody.velocity = new Vector2(rigidbody.velocity.x, -moveSpeed);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(Vector2.up * -0.64f * Time.deltaTime);
        }
        else if (Input.GetKey(keyCodes[2]))
        {
            //rigidbody.velocity = new Vector2(-moveSpeed, rigidbody.velocity.y);
            transform.rotation = Quaternion.Euler(0, 0, 270);
            transform.Translate(Vector2.up * -0.64f * Time.deltaTime);
        }
        else if (Input.GetKey(keyCodes[3]))
        {
            //rigidbody.velocity = new Vector2(moveSpeed, rigidbody.velocity.y);
            transform.rotation = Quaternion.Euler(0, 0, 90);
            transform.Translate(Vector2.up * -0.64f * Time.deltaTime);
        }

    }
}