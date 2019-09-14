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
    public float UpDownMoveSpeed;

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
        if (Input.GetKey(KeyCode.Z) || OVRInput.Get(OVRInput.Button.SecondaryThumbstickUp)) // rotate up
        {
            rig.AddRelativeTorque(Vector3.left * RotateUpDownSpeed);
        }

        if (Input.GetKey(KeyCode.S) || OVRInput.Get(OVRInput.Button.SecondaryThumbstickDown)) // rotate down
        {
            rig.AddRelativeTorque(Vector3.right * RotateUpDownSpeed);
        }

        if (Input.GetKey(KeyCode.Q) || OVRInput.Get(OVRInput.Button.Two)) // lean left
        {
            rig.AddRelativeTorque(Vector3.forward * LeanLeftRightSpeed);
        }

        if (Input.GetKey(KeyCode.D) || OVRInput.Get(OVRInput.Button.One)) // lean right
        {
            rig.AddRelativeTorque(Vector3.back * LeanLeftRightSpeed);
        }

        if (Input.GetKey(KeyCode.A) || OVRInput.Get(OVRInput.Button.SecondaryThumbstickLeft)) // rotate left
        {
            rig.AddRelativeTorque(Vector3.down * RotateLeftRightSpeed);
        }

        if (Input.GetKey(KeyCode.E) || OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight)) // rotate right
        {
            rig.AddRelativeTorque(Vector3.up * RotateLeftRightSpeed);
        }
        #endregion

        #region movements controls

        if (Input.GetKey(KeyCode.UpArrow) || OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp)) // Move forward
        {
            rig.AddRelativeForce(Vector3.forward * ForwardMoveSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow) || OVRInput.Get(OVRInput.Button.PrimaryThumbstickDown)) // Move backward
        {
            rig.AddRelativeForce(Vector3.back * BackMoveSpeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || OVRInput.Get(OVRInput.Button.PrimaryThumbstickLeft)) // Strafe left
        {
            rig.AddRelativeForce(Vector3.left * LeftRightMoveSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow) || OVRInput.Get(OVRInput.Button.PrimaryThumbstickRight)) // Strafe right
        {
            rig.AddRelativeForce(Vector3.right * LeftRightMoveSpeed);
        }

        if (Input.GetKey(KeyCode.R) || OVRInput.Get(OVRInput.Button.Four)) // Move up
        {
            rig.AddRelativeForce(Vector3.up * UpDownMoveSpeed);
        }

        if (Input.GetKey(KeyCode.F) || OVRInput.Get(OVRInput.Button.Three)) // Move down
        {
            rig.AddRelativeForce(Vector3.down * UpDownMoveSpeed);
        }

        #endregion

        #region Reset controls

        if (Input.GetKey(KeyCode.W) || OVRInput.Get(OVRInput.Button.SecondaryThumbstick) ) // Smoothly reset rotation
        {
            rig.rotation = Quaternion.Lerp(rig.rotation, Quaternion.Euler(0, rig.rotation.eulerAngles.y ,0), ResetRotationSpeed);
        }

        #endregion
    }
}
