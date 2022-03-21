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

    private void OnTriggerEnter(Collider other) {

        Player player = other.GetComponent<Player>();
        float dmg = Random.Range(1f, 5f); 

        if (other.tag == "Player") {
            player.PlayerDamage(dmg);
            Destroy(this.gameObject);
        }
    }

    IEnumerator ProyectileDestroy() {
        yield return new WaitForSeconds(2.5f);
        Destroy(this.gameObject);
    }
}