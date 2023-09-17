using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Cam : MonoBehaviour
{
    [SerializeField]
    GameObject ball;
    Vector3 lastPos;


    // Start is called before the first frame update
    void Start()
    {
        lastPos = ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = ball.transform.position - lastPos; 
        if (lastPos != ball.transform.position)
        {
            transform.position += offset;
        }
    }
}
