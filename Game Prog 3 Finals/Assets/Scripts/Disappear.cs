using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    public float cycle;
    public float current = 0f;
    public GameObject platform;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        current += Time.deltaTime;

            if (current >= cycle)
            {

                if (platform.gameObject.activeSelf)
                {
                    Debug.Log("non-active");
                    platform.gameObject.SetActive(false);
                    current = 0f;
                }
                else
                {
                    Debug.Log("active");
                    platform.gameObject.SetActive(true);
                    current = 0f;
                }
                
            }
        
    }
}
