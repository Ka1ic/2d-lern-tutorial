using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapLayer : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.transform.position = collision.gameObject.transform.parent.transform.position;
    }
}
