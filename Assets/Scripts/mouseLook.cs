using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    public float mouseSensitivity = 50f;
    private float mouseX;
    private float mouseY;
    private float xRotation = 0f;

    private GameObjeckt playerBody;

    [Header("Ylös alas suuntainen liikkuminen")]
    public float mixnXAngle = -70f;
    public float maxXAngle = 90f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = Cursorlockmode.Locked;
        playerBody = GameObjeckt.Find("Player");
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltime;

        xRotation -= mouseY;
        xRotation = mathf.Clamp(xRotation, mixnXAngle, maxXAngle);

        transform.localRotation = Quatertnion.Euler(xRotation, 0f, 0f);    

        playerBody.transform.Rotate(Vector3.up * mouseX);
    }

    
    void Update()
    {
        
    }
}
