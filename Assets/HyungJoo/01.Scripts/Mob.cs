using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Mob : MonoBehaviour {
    public float hueMin = 0f;
    public float hueMax = 1f;
    public float saturationMin = 0.7f;
    public float saturationMax = 1f;
    public float valueMin = .7f;
    public float valueMax = 1f;

    public float arrangeRange = .5f;

    public float emissionIntensity = 5f;

    public float destoryDelay = 1f;
    private bool _isDestroyed = false;

    public ParticleSystem environmentParticle;
    public MeshRenderer holeMeshRenderer;
    private NavMeshAgent _agent;

    private ParticleSystem _destroyParticle;
    public AudioSource _destroyAudio;

    public Transform modelTransform;
    private void Awake(){
        _agent = GetComponent<NavMeshAgent>();
        _destroyParticle = transform.Find("MobDestroy").GetComponent<ParticleSystem>();
        _destroyAudio = _destroyParticle.transform.Find("ExplosionAudio").GetComponent<AudioSource>();

    }
    private void Start() {
        SetNavDestination(new Vector3(-3f, 5f, 2f));
        _agent.speed *= Random.Range(.8f, 1.5f);
        RandomColor();

        Invoke(nameof(Destroy),3f);
    }
    public void SetNavDestination(Vector3 pos) {
        _agent.SetDestination(pos);
    }

    private void RandomColor() {
        var color = Random.ColorHSV(hueMin,hueMax,saturationMin,saturationMax,valueMin,valueMax);
        var main = environmentParticle.main;

        main.startColor = new ParticleSystem.MinMaxGradient(color,color * Random.Range(1f - arrangeRange, 1f + arrangeRange));

        var renderer = environmentParticle.GetComponent<ParticleSystemRenderer>();
        renderer.material.SetColor("_EmissionColor",color*emissionIntensity);
        holeMeshRenderer.material.SetColor("_EmissionColor",color*emissionIntensity);
        main = environmentParticle.main;

        main.startColor = new ParticleSystem.MinMaxGradient(color, color * Random.Range(1f - arrangeRange, 1f + arrangeRange));

        renderer = _destroyParticle.GetComponent<ParticleSystemRenderer>();
        renderer.material.SetColor("_EmissionColor", color * emissionIntensity);
    }

    private void Destroy() {
        if (_isDestroyed) return;
        _isDestroyed = true;

        _destroyParticle.Play();
        _destroyAudio.Play();

        environmentParticle.Stop();
        _agent.enabled = false;
        modelTransform.gameObject.SetActive(false);

        Destroy(this.gameObject,destoryDelay);
    }
}