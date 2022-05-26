using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainCharacter : MonoBehaviour
{
    private bool _characterInAir;
    private float _xRotation;
    private float _mouseSensivity;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private float _speed;

    public MainCharacter()
    {
        _xRotation = 0.0f;
        _mouseSensivity = 100.0f;
        _characterInAir = false;
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void FixedUpdate()
    {
        UpdateCharacterInAir();
       // MoveCharacter();
        RotateCharacter();
    }
    private void MoveCharacter()
    {
        float DeltaX = Input.GetAxis("Horizontal");
        float DeltaY = Input.GetAxis("Vertical");
        Vector3 movementVector = new Vector3(DeltaX, 0.0f, DeltaY);
        _rb.MovePosition(movementVector);
    }
    private void RotateCharacter()
    {
        float DeltaX = Input.GetAxis("Mouse X") * _mouseSensivity * Time.deltaTime;
        float DeltaY = Input.GetAxis("Mouse Y") * _mouseSensivity * Time.deltaTime;
        //_xRotation -= DeltaY;
        //_xRotation = Mathf.Clamp(_xRotation, -90.0f, 90.0f);
        Vector3 v = new Vector3(DeltaX, 0.0f, DeltaY);
        _playerTransform.Rotate(v);
    }

    private void UpdateCharacterInAir()
    {
    }
}
