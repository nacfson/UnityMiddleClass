using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVFXColor : MonoBehaviour{
    private ParticleSystem _target;

    public float arrangeRange = .5f;

    private void Awake() {
        _target = GetComponent<ParticleSystem>();    
    }

    public void Call(Color color){
        var main = _target.main;
        main.startColor = new ParticleSystem.MinMaxGradient
            (color,color * Random.Range(1f - arrangeRange, 1f + arrangeRange));
    }
}