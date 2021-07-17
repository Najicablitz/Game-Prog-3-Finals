using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerFollow : MonoBehaviour
{
    public Transform player;
    //public float smoothspeed = 0.125f;
    public Vector3 offset;

    private void FixedUpdate()
    {
        Vector3 position = transform.position;
        position.y = (player.position + offset).y;
        transform.position = position;
    }
}
