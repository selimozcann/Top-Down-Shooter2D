using System;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private Vector3 mousePos;
    public Vector3 MousePos { get{ return  mousePos; } }

    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }
    private void Update()
    {
        mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
    }
}
