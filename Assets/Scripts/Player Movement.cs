using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float Speed = 10f;

    private Rigidbody2D _rigidBody2D;
    private float _horizontalMovement;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody2D = GetComponent<RigidBody2D>()
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalMovement = Input.GetAxis("Horizontal") * Speed;
    }
}
