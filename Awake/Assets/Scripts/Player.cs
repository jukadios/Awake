using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    CharacterController controller;

    [SerializeField]
    float speed = 5f, gravity = 3, jump = 15, yvel = 0;
    bool djump = true;

    void Start() {
        controller = GetComponent<CharacterController>();
        transform.position = new Vector2(0f, 0f);
    }

    void Update() {
        //MovementTpoDown();
        MovementLateral();
    }

    void MovementTpoDown() {

        float hor = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(hor, vert, 0);
        Vector3 vel = dir * speed;

        controller.Move(vel * Time.deltaTime);
    }

    void MovementLateral() {
        float hor = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(hor, vert, 0);
        Vector3 vel = dir * speed;

        if (controller.isGrounded == true) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                yvel = jump;
                djump = true;
            }
        }
        else {
            if (djump && Input.GetKeyDown(KeyCode.Space)) {
                yvel = jump * 1.5f;
                djump = false;
            }
            yvel -= gravity;
        }

        vel.y = yvel;
        controller.Move(vel * Time.deltaTime);
    }
}