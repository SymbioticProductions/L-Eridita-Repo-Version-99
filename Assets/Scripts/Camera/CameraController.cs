using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

//This script will control the camera and its movement

public class CameraController : NetworkBehaviour {

    [SerializeField] private Transform playerCameraTransform = null;
    [SerializeField] public float fl_Movement_Speed;
    [SerializeField] public float fl_Movement_Time;
    [SerializeField] private Vector3 vec_New_Position;

    // Start is called before the first frame update
    public override void OnStartAuthority() {

        playerCameraTransform.gameObject.SetActive(true);
        
        vec_New_Position = transform.position;

    }

    // Update is called once per frame

    [ClientCallback]
    void Update() {

        if (!hasAuthority || !Application.isFocused) {
            return;
        }

        HandleMovementInput();
    }

    //Get Keyboard inputs and map them to vector transformations
    void HandleMovementInput() {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {

            vec_New_Position += (transform.forward * fl_Movement_Speed);

        } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {

            vec_New_Position += (transform.forward * - fl_Movement_Speed);

        } else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {

            vec_New_Position += (transform.right * fl_Movement_Speed);

        } else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {

            vec_New_Position += (transform.right * - fl_Movement_Speed);

        }

        transform.position = Vector3.Lerp(transform.position, vec_New_Position, Time.deltaTime * fl_Movement_Time);

    }

}
