using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDrag : MonoBehaviour
{

    public float _ballPower;
    public Rigidbody2D _rb;

    public Vector2 _minimumpower;
    public Vector2 _maximumpower;
    public LineRenderer _line;
    public Camera _camera;

    Vector2 _ballForce;
    Vector2 _startpoint;
    Vector2 _endpoint;
    Vector2 _currentpoint;

    private bool _ground;
    public AudioClip _sfx;

    private void Awake()
    {
        _line = GetComponent<LineRenderer>();
    }
    void Start()
    {
        _camera = Camera.main;
    }


    void Update()
    {
        if (_ground == true)
        {
            Movement();
        }

    }
    public void Movement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _startpoint = _camera.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButton(0))
        {
            _currentpoint = _camera.ScreenToWorldPoint(Input.mousePosition);

            Drawline(_startpoint, _currentpoint);
        }
        if (Input.GetMouseButtonUp(0))
        {
            _endpoint = _camera.ScreenToWorldPoint(Input.mousePosition);

            _ballForce = new Vector2(Mathf.Clamp(_startpoint.x - _endpoint.x, _minimumpower.x, _maximumpower.x),
                                     Mathf.Clamp(_startpoint.y - _endpoint.y, _minimumpower.y, _maximumpower.y));
            _rb.AddForce(_ballForce * _ballPower, ForceMode2D.Impulse);
            Debug.Log(_ballForce * _ballPower);
            endline();
            AudioManager.instance.GUISFX(_sfx);
        }
    }

    public void Drawline(Vector3 startpoint, Vector3 endpoint)
    {
        _line.positionCount = 2;
        Vector3[] Allpoint = new Vector3[2];
        Allpoint[0] = startpoint;
        Allpoint[1] = endpoint;
        _line.SetPositions(Allpoint);
    }
    public void endline()
    {
        _line.positionCount = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform") || collision.gameObject.CompareTag("floor"))
        {
            _ground = true;
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform") || collision.gameObject.CompareTag("floor"))
        {
            _ground = false;
        }
    }


   


}
