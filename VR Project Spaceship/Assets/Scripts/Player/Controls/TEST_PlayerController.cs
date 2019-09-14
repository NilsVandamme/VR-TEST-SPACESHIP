using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST_PlayerController : MonoBehaviour
{
    private Rigidbody rig;

    [Header("Move Speed")]
    public float ForwardMoveSpeed;
    public float BackMoveSpeed;
    public float LeftRightMoveSpeed;

    [Header("Rotation Speed")]
    public float RotateUpDownSpeed;
    public float LeanLeftRightSpeed;
    public float RotateLeftRightSpeed;
    public float ResetRotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // ROTATIONS KEYS
        // INPUTS MAY BE WIP


        #region rotations controls
        if (Input.GetKey(KeyCode.A)) // rotate up
        {
            rig.AddRelativeTorque(Vector3.left * RotateUpDownSpeed);
        }

        if (Input.GetKey(KeyCode.Q)) // rotate down
        {
            rig.AddRelativeTorque(Vector3.right * RotateUpDownSpeed);
        }

        if (Input.GetKey(KeyCode.Z)) // lean left
        {
            rig.AddRelativeTorque(Vector3.forward * LeanLeftRightSpeed);
        }

        if (Input.GetKey(KeyCode.S)) // lean right
        {
            rig.AddRelativeTorque(Vector3.back * LeanLeftRightSpeed);
        }

        if (Input.GetKey(KeyCode.E)) // rotate left
        {
            rig.AddRelativeTorque(Vector3.up * RotateLeftRightSpeed);
        }

        if (Input.GetKey(KeyCode.D)) // rotate right
        {
            rig.AddRelativeTorque(Vector3.down * RotateLeftRightSpeed);
        }
        #endregion

        #region movements controls

        if (Input.GetKey(KeyCode.UpArrow)) // Move forward
        {
            rig.AddRelativeForce(Vector3.forward * ForwardMoveSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow)) // Move backward
        {
            rig.AddRelativeForce(Vector3.back * BackMoveSpeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) // Strafe left
        {
            rig.AddRelativeForce(Vector3.left * LeftRightMoveSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow)) // Strafe right
        {
            rig.AddRelativeForce(Vector3.right * LeftRightMoveSpeed);
        }

        #endregion

        #region Reset controls

        if (Input.GetKey(KeyCode.W)) // Smoothly reset rotation
        {
            rig.rotation = Quaternion.Lerp(rig.rotation, Quaternion.identity, ResetRotationSpeed);
        }

        #endregion
    }
}
