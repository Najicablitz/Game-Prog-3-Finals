using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerFollow : MonoBehaviour
{
    public Transform _player;
    //public float smoothspeed = 0.125f;
    public Vector3 _offset;

    private void FixedUpdate()
    {
        Vector3 position = transform.position;
        position.y = (_player.position + _offset).y;
        transform.position = position;
    }
}
