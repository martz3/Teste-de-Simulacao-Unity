using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public Vector2 turn;
    public float sensivityMouseY = 4.5f;
    public float sensivityMouseX = 0f;
    public Vector3 deltaMove;
    public float speed = 1;
    public GameObject mover;

    // Start is called before the first frame update
    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Rotacao();
    }

    public void Rotacao()
    {
        turn.x += Input.GetAxis("Mouse X") * sensivityMouseX;
        turn.y += Input.GetAxis("Mouse Y") * sensivityMouseY;

        mover.transform.localRotation = Quaternion.Euler(0, turn.x, 0);
        transform.localRotation = Quaternion.Euler(-turn.y, 0, 0);

        deltaMove = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;
        mover.transform.Translate(deltaMove);
    }
}