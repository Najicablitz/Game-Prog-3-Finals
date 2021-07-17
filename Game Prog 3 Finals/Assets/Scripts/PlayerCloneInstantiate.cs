using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCloneInstantiate : MonoBehaviour
{
    public GameObject playerClone;
    public Transform cloneIns;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject clone = Instantiate(playerClone, cloneIns.position, cloneIns.rotation);
        }
    }
}
