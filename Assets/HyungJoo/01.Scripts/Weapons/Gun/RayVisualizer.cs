using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayVisualizer : MonoBehaviour{
    [Header("Ray")]
    private LineRenderer _ray;
    private LayerMask _hitRayMask;
    [SerializeField] private float _distance = 100f;
    
    [Header("Reticle Point")]
    private Transform _reticlePoint;
    public bool _isShowReticle = true;

    private void Awake() {
        _ray = transform.Find("Line").GetComponent<LineRenderer>();
        _reticlePoint = transform.Find("ReticlePoint");
        Off();
    }

    public void On(){

    }
    public void Off(){

    }
}