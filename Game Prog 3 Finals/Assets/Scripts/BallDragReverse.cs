using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDragReverse : MonoBehaviour
{
    public float _ballPower;
    public Rigidbody2D rb;

    public Vector2 minimumpower;
    public Vector2 maximumpower;
    public LineRenderer line;
    Camera camera;
    Vector2 _ballForce;
    Vector2 startpoint;
    Vector2 endpoint;

    private void Awake()
    {
        line = GetComponent<LineRenderer>();
    }
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startpoint = camera.ScreenToWorldPoint(Input.mousePosition);
            //startpoint.z = 10;
        }
        if (Input.GetMouseButton(0))
        {
            Vector2 currentpoint = camera.ScreenToWorldPoint(Input.mousePosition);
            // currentpoint.z = 10;
            //Drawline(startpoint, currentpoint);
        }
        if (Input.GetMouseButtonUp(0))
        {
            endpoint = camera.ScreenToWorldPoint(Input.mousePosition);
            // endpoint.z = 10;

            _ballForce = new Vector2(Mathf.Clamp(endpoint.x - startpoint.x, minimumpower.x, maximumpower.x),
                                     Mathf.Clamp(startpoint.y - endpoint.y, minimumpower.y, maximumpower.y));
            rb.AddForce(_ballForce * _ballPower, ForceMode2D.Impulse);
           // endline();
        }
    }

   /* public void Drawline(Vector3 startpoint, Vector3 endpoint)
    {
        line.positionCount = 2;
        Vector3[] Allpoint = new Vector3[2];
        Allpoint[0] = startpoint;
        Allpoint[1] = endpoint;
        line.SetPositions(Allpoint);
    }
    public void endline()
    {
        line.positionCount = 0;
    }*/
}
