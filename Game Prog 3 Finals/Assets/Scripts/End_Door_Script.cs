using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Door_Script : MonoBehaviour
{
    public GameObject _win;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _win.SetActive(true);
            Time.timeScale = 0;
        }
    }


}
