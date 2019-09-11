﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{

    public UnityEvent triggerEvent;
    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
    }
}
