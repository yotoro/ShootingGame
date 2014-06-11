using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public float speed = 10.0f;
    public float rayDistance = 10.0f;


    void Update()
    {
        종상이바보
        gameObject.transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
    }
}