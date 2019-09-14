using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST_PlayerController : MonoBehaviour
{
    private Rigidbody rig;

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
            rig.AddRelativeTorque(Vector3.left);
        }

        if (Input.GetKey(KeyCode.Q)) // rotate down
        {
            rig.AddRelativeTorque(Vector3.right);
        }

        if (Input.GetKey(KeyCode.Z)) // lean left
        {
            rig.AddRelativeTorque(Vector3.forward * 0.2f);
        }

        if (Input.GetKey(KeyCode.S)) // lean right
        {
            rig.AddRelativeTorque(Vector3.back * 0.2f);
        }

        if (Input.GetKey(KeyCode.E)) // rotate left
        {
            rig.AddRelativeTorque(Vector3.up);
        }

        if (Input.GetKey(KeyCode.D)) // rotate right
        {
            rig.AddRelativeTorque(Vector3.down);
        }
        #endregion

        #region movements controls

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rig.AddRelativeForce(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rig.AddRelativeForce(Vector3.back);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rig.AddRelativeForce(Vector3.left);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rig.AddRelativeForce(Vector3.right);
        }

        #endregion
    }
}
