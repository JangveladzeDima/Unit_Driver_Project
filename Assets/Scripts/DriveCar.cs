using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveCar : MonoBehaviour {
    [SerializeField] private float carSpeed = 5f;
    [SerializeField] private float rotateSpeed = 100f;

    void start(){
    }

    void Update(){
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        if (moveVertical < 0){
            transform.Rotate(0, 0, moveHorizontal * rotateSpeed * Time.deltaTime);
        }
        else{
            transform.Rotate(0, 0, -moveHorizontal * rotateSpeed * Time.deltaTime);
        }

        transform.Translate(0, moveVertical * carSpeed * Time.deltaTime, 0);
    }
}