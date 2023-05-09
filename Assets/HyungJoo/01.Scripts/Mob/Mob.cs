using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
public class Mob : MonoBehaviour {
    public UnityEvent OnCreated;
    public UnityEvent OnDestroyed;

    public float destoryDelay = 1f;
    private bool _isDestroyed = false;

    public Transform modelTransform;
    private void Start() {
        OnCreated?.Invoke();

        Invoke(nameof(Destroy),3f);
    }

    private void Destroy() {
        if (_isDestroyed) return;
        _isDestroyed = true;

        OnDestroyed?.Invoke();
        Destroy(this.gameObject,destoryDelay);
    }
}