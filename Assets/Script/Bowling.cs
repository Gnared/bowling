using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bowling : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _rb;

    [SerializeField]
    private GameObject text;

    [SerializeField]
    private float forcePower;
    [SerializeField]
    private float leftEdge;
    [SerializeField]
    private float rightEdge;
    [SerializeField]
    private float increment;
    [SerializeField]
    private GameObject effectLine;

    private bool isForceOver;
    private bool isShot;
    private bool isAim;

    public bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&!isShot)
        {
            effectLine.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Space) && !isShot)
        {
            AimPower();
        }
        if (Input.GetKeyUp(KeyCode.Space) && !isShot)
        {
            effectLine.SetActive(false);
            ShootBowl();
        }

        if (Input.GetKey(KeyCode.E) && !isAim)
        {
            RotateCWBowl();
        }
        if (Input.GetKey(KeyCode.Q) && !isAim)
        {
            RotateCCWBowl();
        }

        if (Input.GetKey(KeyCode.A) && !isAim)
        {
            MoveLeft();
        }
        if (Input.GetKey(KeyCode.D) && !isAim)
        {
            MoveRight();
        }
    }

    private void RotateCWBowl()
    {
        if (transform.rotation.y <= Quaternion.Euler(0,15,0).y)
        {
            transform.Rotate(Vector3.up * 90 * Time.deltaTime);
        }
    }

    private void RotateCCWBowl()
    {
        if (transform.rotation.y >= Quaternion.Euler(0, -15, 0).y)
        {
            transform.Rotate(Vector3.up * -90 * Time.deltaTime);
        }
    }

    public void ShootBowl()
    {
        _rb.AddForce(forcePower / 10 * transform.forward, ForceMode.Impulse);
        text.GetComponent<Text>().showButton("Lucky");
        isShot = true;
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

    public void AimPower()
    {
        text.GetComponent<Text>().showButton("Drag");
        isAim = true;
        if (isForceOver)
        {
            forcePower--;
        }
        else
        {
            forcePower++;
        }
        if (forcePower > 400)
        {
            isForceOver = true;
        }
        if (forcePower < 100)
        {
            isForceOver = false;
        }

        effectLine.transform.localScale = new Vector3(1f, 1f, forcePower / 100);
    }

}
