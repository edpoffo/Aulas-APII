using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamuraiPlayer : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    
    private Rigidbody2D _rb2D;
    private SpriteRenderer _renderer;
    private Animator _animator;
    private void Awake()
    {
        _rb2D = gameObject.GetComponent<Rigidbody2D>();
        _animator = gameObject.GetComponent<Animator>();
        _renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveLaterally();
        Attack();
    }

    private void Attack()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _animator.SetTrigger("Attack");
        }
    }

    public void AttackHit()
    {
        
    }

    private void MoveLaterally()
    {
        var movement = Input.GetAxis("Horizontal");
        
        _rb2D.velocity = new Vector2(movement * speed, _rb2D.velocity.y);

        if (_rb2D.velocity.x < 0f)
        {
            _renderer.flipX = true;
        }
        else if (_rb2D.velocity.x > 0f)
        {
            _renderer.flipX = false;
        }
        _animator.SetFloat("VelocityX", Mathf.Abs(_rb2D.velocity.x));
    }
}
