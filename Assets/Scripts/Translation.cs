using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translation : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField]
    private float _speed = 2f;
    private float _timer = 0f;
    [SerializeField]
    private float _toggleDirectionTime = 1f;
    private int invert = 1;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _timer = 0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _timer += Time.deltaTime;
        if (_timer >= _toggleDirectionTime)
        {
            _timer = 0f;
            invert *= -1;
        }
        _rigidbody.velocity = invert * transform.up * _speed;
    }
}
