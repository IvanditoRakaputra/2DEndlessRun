using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    public UnityEvent onGameStart;

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            onGameStart.Invoke();
        }
    }
}
