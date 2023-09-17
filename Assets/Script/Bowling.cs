using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bowling : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _rb;

    [SerializeField]
    private int forcePower;
    [SerializeField]
    private float leftEdge;
    [SerializeField]
    private float rightEdge;
    [SerializeField]
    private float increment;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBowl();
        }

        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }
    }


    public void ShootBowl()
    {
        _rb.AddForce(forcePower * Vector3.forward, ForceMode.Impulse);
    }

    private void MoveLeft()
    {
        if (transform.position.x >= leftEdge)
        {
            transform.position += new Vector3(-increment, 0f, 0f);
        }
    }
    private void MoveRight()
    {
        if (transform.position.x <= rightEdge)
        {
            transform.position += new Vector3(+increment, 0f, 0f);
        }
    }
}
