using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField]
    GameObject proyectile;

    bool inst = true;
    void Start() {
        
    }

    void Update() {
        if(inst)
            StartCoroutine(Proyectiles());
    }

    IEnumerator Proyectiles() {
        inst = false;
        Instantiate(proyectile, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        inst = true;
    }
}