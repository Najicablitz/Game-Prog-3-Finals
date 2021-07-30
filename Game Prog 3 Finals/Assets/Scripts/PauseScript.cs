using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public GameObject _pause;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Paused();
        }
       
    }

    public void Paused()
    {
        _pause.SetActive(true);
        Time.timeScale = 0;
    }

    public void Unpaused()
    {
        _pause.SetActive(false);
        Time.timeScale = 1;
    }
}
