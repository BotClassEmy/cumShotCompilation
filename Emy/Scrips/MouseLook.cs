using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensibility = 100f;
    public Transform playerBody;

    private float xRotation;

   
    void Start()
    {
        
    }

    
    void Update()
    {   //Variables para el movimiento horizontal y vertical 
        //Devuelve el valor del eje virtual identificado por axisName.
        float mouseX = Input.GetAxis("Mouse X") * mouseSensibility * Time.deltaTime; //Se agrega el time.deltaTime para que el input del raton sea independiente de la tasa de refresco
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensibility * Time.deltaTime; //Nos devuelve el tiempo que ah pasado entre un frame y el anterior

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation,-90f, 90);

        playerBody.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(xRotation, 0 , 0);

    }
}
