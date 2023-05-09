using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Goal : MonoBehaviour
{
    [SerializeField] UnityEvent OnBallGoal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            OnBallGoal.Invoke();
            Debug.Log("GOAL");
        }
    }
}
