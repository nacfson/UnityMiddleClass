using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEmissionColor : MonoBehaviour{
    private Renderer _target;
    public float emissionIntensity = 5f;

    private void Awake() {
        _target = GetComponent<Renderer>();
    } 

    public void Call(Color color){
        _target.material.SetColor("_EmissionColor", color * emissionIntensity);

    }
}