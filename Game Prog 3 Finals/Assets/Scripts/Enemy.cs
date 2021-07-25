using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject _bullet;
    private float _distoPlayer;
    public float _range;
    public float _fireRate;
    public float _nextFire;
    public Transform _player;

    void Start()
    {
        
        _nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        _distoPlayer = Vector2.Distance(transform.position, _player.position);
        Debug.Log(_distoPlayer);
        if (_distoPlayer <= _range)
        {
            CheckFire();
        }
        
    }

    public void CheckFire()
    {
        if(Time.time >= _nextFire)
        {
            Instantiate(_bullet, transform.position, Quaternion.identity);
            _nextFire = Time.time + _fireRate;
        }
        
    }
}
