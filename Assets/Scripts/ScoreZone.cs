using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("aaaa");

        if (collider.tag == "Shuttle")
        {
            Debug.Log("aaaa");
            GameLogicManager.Instance.AddScore(1);
        }
    }
}
