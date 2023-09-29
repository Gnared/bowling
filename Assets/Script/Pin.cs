using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField]
    GameObject Rail;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Rail)
        {
            if(GameManager.instance.Score < 10)
            GameManager.instance.Score++;
        }
    }
}
