using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTD : MonoBehaviour{

    [SerializeField] float speed = 8;
    float hori, vert;
    Vector3 moveDirection;

    void Start(){

    }

    void Update(){
        MovementTpoDown();
    }

    void MovementTpoDown(){
        hori = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");

        moveDirection.x = hori;
        moveDirection.y = vert;

        transform.position += moveDirection * Time.deltaTime * speed;
    }
}

