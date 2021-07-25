using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    public float _cycle;
    public float _current = 0f;
    public GameObject _platform;

    // Update is called once per frame
    void FixedUpdate()
    {
        _current += Time.deltaTime;

            if (_current >= _cycle)
            {

                if (_platform.gameObject.activeSelf)
                {
                    Debug.Log("non-active");
                    _platform.gameObject.SetActive(false);
                    _current = 0f;
                }
                else
                {
                    Debug.Log("active");
                    _platform.gameObject.SetActive(true);
                    _current = 0f;
                }
                
            }
        
    }
}
