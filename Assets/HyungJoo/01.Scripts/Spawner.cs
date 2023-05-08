using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour {
    [SerializeField] private Transform _prefab;

    public bool playOnStart = true;
    public float startFactor = 1f;
    public float additiveFactor = 0.1f;
    public float delayperSpawnGroup = 3f;

    private void Start() {
        if (playOnStart) {
            Play();
        }
    }
    public void Play() {
        StartCoroutine(Process());
    }
    public void Stop() {
        StopAllCoroutines();
    }

    private IEnumerator Process() {
        var factor = startFactor;
        var wfs = new WaitForSeconds(delayperSpawnGroup);

        while (true) {
            yield return wfs;
            yield return StartCoroutine(SpawnProcess(factor));
            factor += additiveFactor;
        }
    }

    private IEnumerator SpawnProcess(float factor) {
        var count = Random.Range(factor, factor * 2);
        for (int i = 0; i < count; i++) {
            Spawn();

            if (Random.value < 0.2f) {
                yield return new WaitForSeconds(Random.Range(0.01f,0.02f));
            }
        }
    }
    private void Spawn() {
        Transform prefab = Instantiate(_prefab,transform.position,transform.rotation);
    }
}