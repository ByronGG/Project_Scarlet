using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control_Player : MonoBehaviour
{
    public CharacterController controller;
    public float velocidad;
    public float velocidadRotacion;
    public GameObject Camara;
    float xRotation;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("arma"))
        {
            Debug.Log("Estas muerto!");
            SceneManager.LoadScene(2);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        controller.Move(transform.forward * z * velocidad * Time.deltaTime);
        controller.Move(transform.right * x * velocidad * Time.deltaTime);

        float mouseX = Input.GetAxis("Mouse X") * velocidadRotacion * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * velocidadRotacion * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -55f, 55f);

        Camara.transform.localRotation = Quaternion.Euler(xRotation ,0, 0);

        transform.Rotate(Vector3.up * mouseX);

    }
}
