using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectile : MonoBehaviour {

    void Start() {
        
    }

    void Update() {
        if(this.gameObject != null) {
            ProyectileMovement();
            StartCoroutine(ProyectileDestroy());
        }
    }

    void ProyectileMovement() {
        transform.Translate(Vector3.left * 2f * Time.deltaTime);
    }

    IEnumerator ProyectileDestroy() {
        yield return new WaitForSeconds(2.5f);
        Destroy(this.gameObject);
    }
}