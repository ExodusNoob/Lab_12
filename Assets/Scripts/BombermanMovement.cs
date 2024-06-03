using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int speed;
    public float horizontal;
    public float vertical;
    private Rigidbody2D _compRigidbody2D;
    private SpriteRenderer _compSpriteRenderer;
    // Start is called before the first frame update
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        _compRigidbody2D.velocity = new Vector2(speed * horizontal, speed * vertical);
        if (Input.GetKeyDown("d") == true || Input.GetKeyDown(KeyCode.RightArrow))
        {
            _compSpriteRenderer.flipX = false;
        }
        if (Input.GetKeyDown("a") == true || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _compSpriteRenderer.flipX = true;
        }
    }
}
