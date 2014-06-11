using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public float speed = 10.0f;
    public float rayDistance = 1.0f;

    void Update()
    {
        gameObject.transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);

        detection();
    }

    void detection()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * rayDistance, Color.red);

        if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance))
        {
            if (hit.collider.gameObject.name == "Bottom")
            {
                gameObject.SetActive(false);
            }
        }
    }
}