using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Door_Script : MonoBehaviour
{
    public GameObject win;
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            win.SetActive(true);
            Time.timeScale = 0;
        }
    }


}
