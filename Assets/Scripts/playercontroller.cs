using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float Speed = 10f;
    public float JumpForce = 10f;

    private Rigidbody2D _rigidBody2D;
    private float _horizontalMovement;
    private Rigidbody2D _spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalMovement = Input.GetAxisRaw("Horizontal") * Speed;

        if (_horizontalMovement < 0)
        {
            _spriteRenderer.flipX = true;
        }
        else if (0 < _horizontalMovement)
        {
            _spriteRenderer.flipX = false;
        }

        if (Input.GetButton("Jump"))
        {
            _rigidBody2D.velocity = new Vector2(_rigidBody2D.velocity.x, JumpForce);

        }
    }

private void FixedUpdate () {
    _rigidBody2D.velocity = new Vector2(_horizontalMovement * Speed * Time.fixedDeltaTime, _rigidBody2D.velocity.y);
}

}
