using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    private Transform lookAt;
    public float boundX = .3f;
    public float boundY = .15f;

    private void Start()
    {
        lookAt = GameObject.Find("Player").transform;
    }

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;
        float deltaX = lookAt.position.x - transform.position.x;
        if (deltaX > boundX || deltaX < -boundX)
        {
            if (transform.position.x < lookAt.transform.position.x)
                delta.x = deltaX - boundX;
            else
                delta.x = deltaX + boundX;
        }

        float deltaY = lookAt.position.y - transform.position.y;
        if (deltaY > boundY || deltaY < -boundY)
        {
            if (transform.position.y < lookAt.transform.position.y)
                delta.y = deltaY - boundY;
            else
                delta.y = deltaY + boundY;
        }

        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}