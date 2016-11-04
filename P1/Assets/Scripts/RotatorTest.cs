using UnityEngine;
using System.Collections;

public class RotatorTest : MonoBehaviour {

    public bool isRight;

    public float flipperStrength;
    public float pushForce;
    private HingeJoint hinge;

	// Use this for initialization
	void Start () {
        hinge = GetComponent<HingeJoint>();

	}

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Vector3 f;

            if (isRight)
            {
                f = transform.up * flipperStrength;
            }

            else
            {
                f = -transform.up * flipperStrength;
            }
            Vector3 p = (transform.right) + transform.position * pushForce;
            GetComponent<Rigidbody>().AddForceAtPosition(f, transform.position);
        }
    }	
}
