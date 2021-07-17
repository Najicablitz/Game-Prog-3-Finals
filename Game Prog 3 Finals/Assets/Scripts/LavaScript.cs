using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour
{
    public Transform finalPos;
    public float speed;
    public Transform startPos;
    Vector3 nexPos;
    void Start()
    {
        nexPos = finalPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, nexPos, speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }


}
