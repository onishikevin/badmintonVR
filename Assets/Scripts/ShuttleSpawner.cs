using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuttleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _shuttle;
    [SerializeField]
    private float _timeBetweenSpawns = 8f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Co_ShuttleSpawner());
    }

    private IEnumerator Co_ShuttleSpawner()
    {
        while (true)
        {
            GameObject newShuttle = Instantiate(_shuttle, transform.position, Quaternion.identity);
            newShuttle.GetComponent<Rigidbody>().velocity = new Vector3(8f, 8f, 0f);
            yield return new WaitForSeconds(_timeBetweenSpawns);
        }
    }
}
