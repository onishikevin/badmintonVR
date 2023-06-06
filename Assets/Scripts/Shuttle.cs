using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Shuttle : MonoBehaviour
{
    [SerializeField]
    private float _animationDuration = 0.2f;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (_rigidbody.velocity.magnitude > 0f)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity) * Quaternion.Euler(-90, 0, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Racket")
        {
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.AddForce(collision.impulse.normalized * 550f);
            //StartCoroutine(ChangeFlightDirection());
        }
    }

    private IEnumerator ChangeFlightDirection()
    {
        float time = 0f;
        Quaternion originalRotation = transform.rotation;
        Quaternion rot180degrees = Quaternion.Euler(-originalRotation.eulerAngles);

        while (time < _animationDuration)
        {
            transform.rotation = Quaternion.Lerp(originalRotation, rot180degrees, time / _animationDuration);
            time += Time.deltaTime;
            yield return null;
        }
    }
}