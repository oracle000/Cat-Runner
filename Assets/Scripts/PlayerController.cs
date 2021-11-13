using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D _rb;
    private Animator _animator;
    private Collider2D _collider;    

    [SerializeField] private LayerMask ground;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _collider = GetComponent<Collider2D>();
    }


    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        var jumping = Input.GetAxis("Vertical");

        if (movement > 0 )
		{
            transform.Translate(new Vector3(3 * Time.deltaTime, 0, 0), Space.Self);
            transform.localScale = new Vector3(1, 1, 1);
            SetJumpRunAnimation(jumping);
        } else if (movement < 0)
		{           
            transform.Translate(new Vector3(-3 * Time.deltaTime, 0, 0), Space.Self);
            transform.localScale = new Vector3(-1, 1, 1);
            SetJumpRunAnimation(jumping);            
        } else if (movement == 0 && jumping == 0)
		{
            _animator.SetBool("AlfredoIdle", true);            
        }

        if (jumping > 0 && _collider.IsTouchingLayers(ground))
		{        
			_rb.velocity = new Vector2(_rb.velocity.x, 5f);            
            _animator.SetBool("AlfredoJump", true);
	    } 
    }


    private void SetJumpRunAnimation(float jumping)
	{
        if (jumping > 0)
        {
            _animator.SetBool("AlfredoJump", true);
        }
        else
        {
            _animator.SetBool("AlfredoRun", true);
        }
    }
}
