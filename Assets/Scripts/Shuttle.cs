using UnityEngine;

public class Shuttle : MonoBehaviour
{
    [SerializeField]
    private bool _faceTravellingDirection = true;

    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (_rigidbody.velocity.magnitude > 0f && _faceTravellingDirection)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity) * Quaternion.Euler(-90, 0, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.collider.tag)
        {
            case "Racket":
                {
                    _rigidbody.velocity = Vector3.zero;
                    _rigidbody.AddForce(collision.impulse.normalized * 550f);
                    break;
                }
            case "ServeZoneRight":
                {
                    // Add points to Player
                    break;
                }
            case "ServeZoneLeft":
                {
                    // Add points to Player
                    break;
                }
            case "PlayZone":
                {
                    // Add points to Player
                    break;
                }
            default:
                {
                    break;
                }
        }
    }

    public void SetFaceTravellingDirection(bool active)
    {
        transform.rotation = Quaternion.identity;
        _faceTravellingDirection = active;
    }

}