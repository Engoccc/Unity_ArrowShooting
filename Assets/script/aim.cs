using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aim : MonoBehaviour
{
    Rigidbody rigiBD;
    [SerializeField]
    Camera cam;


    // Start is called before the first frame update
    void Start()
    {
        rigiBD = GetComponent<Rigidbody>();
        cam = GetComponentInChildren<Camera>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        aimLogic();
    }

    void aimLogic()
    {
        float _leftRightValue = Input.GetAxisRaw("Mouse X");
        float _upDownValue = Input.GetAxisRaw("Mouse Y");
        Vector3 _rotationX = new Vector3(_upDownValue, 0, 0);
        Vector3 _rotationY = new Vector3(0, _leftRightValue, 0);

        rigiBD.MoveRotation(rigiBD.rotation * Quaternion.Euler(_rotationY));
        cam.transform.Rotate(_rotationX);

    }
}
