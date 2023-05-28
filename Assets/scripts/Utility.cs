using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Utility : MonoBehaviour
{
    public static int using_axis = 0;
    [SerializeField] private float zoom_speed;
    [SerializeField] private Camera cam;
    public InputAction zoom;

    private void OnEnable()
    {
        zoom.Enable();
    }

    private void OnDisable()
    {
        zoom.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        float read = zoom.ReadValue<float>();
        cam.fieldOfView = cam.fieldOfView + (read*zoom_speed);
        //Vector3 translation = cam.transform.position.normalized + cam.transform.position.normalized * zoom_speed * read;
    }
}
