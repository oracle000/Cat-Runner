using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D _rb;
    private Animator _animator;
    private Collision2D _collision;
    private bool IsJumping;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _collision = GetComponent<Collision2D>();
    }


    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        var jumping = Input.GetAxis("Vertical");
        if (movement > 0)
		{
            transform.Translate(new Vector3(3 * Time.deltaTime, 0, 0), Space.Self);
            transform.localScale = new Vector3(1, 1, 1);
            _animator.SetBool("AlfredoRun", true);            

        } else if (movement < 0)
		{           
            transform.Translate(new Vector3(-3 * Time.deltaTime, 0, 0), Space.Self);
            transform.localScale = new Vector3(-1, 1, 1);
            _animator.SetBool("AlfredoRun", true);            
        } else if (movement == 0)
		{
            _animator.SetBool("AlfredoIdle", true);            
        }

        if (jumping > 0 && IsJumping == false)
		{
            IsJumping = true;
			_rb.velocity = new Vector2(_rb.velocity.x, 5f);
            // transform.Translate(new Vector3(0, .5f, 0), Space.Self);
		} else
		{
            IsJumping = false;
		}

    }
}
