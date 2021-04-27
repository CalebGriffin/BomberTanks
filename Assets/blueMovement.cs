using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueMovement : MonoBehaviour
{
    [Range(1, 2)]
    public int playerNum;
    public KeyCode[] keyCodesRed;
    Rigidbody2D rigidbody;
    public float moveSpeed = 0.64f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();

        
    }

    public void UpdateMovement()
    {
        if (Input.GetKey(keyCodesRed[0]))
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, moveSpeed);
            transform.rotation = Quaternion.Euler(0, 0, 180);
            StartCoroutine(SlowDown());
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, 0);
        }
        else if (Input.GetKey(keyCodesRed[1]))
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, -moveSpeed);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            StartCoroutine(SlowDown());
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, 0);
        }
        else if (Input.GetKey(keyCodesRed[2]))
        {
            rigidbody.velocity = new Vector2(-moveSpeed, rigidbody.velocity.y);
            transform.rotation = Quaternion.Euler(0, 0, 270);
            StartCoroutine(SlowDown());
            rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);

        }
        else if (Input.GetKey(keyCodesRed[3]))
        {
            rigidbody.velocity = new Vector2(moveSpeed, rigidbody.velocity.y);
            transform.rotation = Quaternion.Euler(0, 0, 90);

            StartCoroutine(SlowDown());
            rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
        }

        IEnumerator SlowDown()
        {
            yield return new WaitForSeconds(1f);
        }


    }
}
