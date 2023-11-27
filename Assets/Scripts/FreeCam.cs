using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCameraMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float sensitivity = 2f;

    void Start()
    {
        // Oyun ba�lad���nda fareyi ekran�n ortas�na sabitle
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Kamera hareketi
        float horizontalMovement = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        float verticalMovement = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        transform.Translate(new Vector3(horizontalMovement, 0, verticalMovement));

        // Fareyle kamera d�nd�rme
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        transform.Rotate(Vector3.up * mouseX);

        // Kameran�n a��r� yukar� veya a�a�� d�nmesini engelleme
        float currentRotation = transform.rotation.eulerAngles.x;
        float newRotation = Mathf.Clamp(currentRotation - mouseY, 0f, 80f);

        transform.rotation = Quaternion.Euler(newRotation, transform.rotation.eulerAngles.y, 0f);

        // Oyun �al���rken fareyi gizle
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}

