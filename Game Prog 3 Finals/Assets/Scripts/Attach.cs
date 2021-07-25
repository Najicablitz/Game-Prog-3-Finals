using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attach : MonoBehaviour
{
    public GameObject _player;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            _player.transform.parent = other.gameObject.transform;
        }
    }


    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            _player.transform.parent = null;
        }
    }

}
