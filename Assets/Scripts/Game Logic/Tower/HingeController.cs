using Fizzyo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HingeController : MonoBehaviour
{
    private Rigidbody connectedBody;
    private HingeJoint hinge;

    [SerializeField] private GameObject connectedBodyPrefab;

    public void Drop()
    {
        hinge.connectedBody = null;
    }

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    void Update()
    {
        if (FizzyoFramework.Instance.Device.ButtonDown())
        {
            Drop();
        }
    }
}
