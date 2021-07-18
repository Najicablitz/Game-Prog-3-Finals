using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDrag : MonoBehaviour
{
    public Transform Player;
    public float _ballPower;
    public Rigidbody2D rb;

    public Vector2 minimumpower;
    public Vector2 maximumpower;
    public LineRenderer line;
    private Camera camera;
    Vector2 _ballForce;
    Vector2 startpoint;
    Vector2 endpoint;
    public bool ground;

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
        if(ground == true)
        {
            Movement();
        }       
    }
    public void Movement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startpoint = /*Player.position;*/  camera.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButton(0))
        {
            Vector2 currentpoint = camera.ScreenToWorldPoint(Input.mousePosition);

            Drawline(startpoint/*Player.position*/, currentpoint);
        }
        if (Input.GetMouseButtonUp(0))
        {
            endpoint = camera.ScreenToWorldPoint(Input.mousePosition);

            _ballForce = new Vector2(Mathf.Clamp(startpoint.x - endpoint.x, minimumpower.x, maximumpower.x),
                                     Mathf.Clamp(startpoint.y - endpoint.y, minimumpower.y, maximumpower.y));
            rb.AddForce(_ballForce * _ballPower, ForceMode2D.Impulse);
            Debug.Log(_ballForce * _ballPower);
            endline();
        }
    }

    public void Drawline(Vector3 startpoint, Vector3 endpoint)
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
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            ground = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            ground = false;
        }
    }


   


}
