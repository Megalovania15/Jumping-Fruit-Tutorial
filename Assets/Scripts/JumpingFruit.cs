using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingFruit : MonoBehaviour
{
    public float[] forces;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int index = Random.Range(0, forces.Length);
            Vector2 jumpForce = new Vector2(0, forces[index]);
            rb.AddForce(jumpForce, ForceMode2D.Impulse);
        }
    }
}
