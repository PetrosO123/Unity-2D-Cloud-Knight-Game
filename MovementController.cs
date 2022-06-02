using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementController : MonoBehaviour
{
    [SerializeField] private LayerMask groundLayerMask;
    public float maxSpeed = 15.0f;
    bool bFlipFacing = true;
    Animator anim;
    Rigidbody2D rb;
    public float jumpQuantity = 8;
    public bool jumpBool = true;
    private BoxCollider2D bc2d;
    public float dashQuantity = 800;

    private void Awake()
    {
        bc2d = transform.GetComponent<BoxCollider2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        if (!bFlipFacing)
            FlipFacing();
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(move));
        rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);
        if (Input.GetMouseButtonDown(1) && IsGrounded()){
            rb.velocity = Vector2.up * jumpQuantity;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && IsGrounded())
        {
            rb.transform.position = new Vector2(rb.transform.position.x-20f, rb.transform.position.y);
        }
        if (Input.GetKeyDown(KeyCode.RightShift) && IsGrounded())
        {
            rb.transform.position = new Vector2(rb.transform.position.x+20f, rb.transform.position.y);
        }

        if (move < 0 && bFlipFacing)
            FlipFacing();
        else if (move > 0.01 && !bFlipFacing)
            FlipFacing();
        if (Input.GetKeyDown(KeyCode.K))
        {
            SceneManager.LoadScene(0);
        }

    }

    private bool IsGrounded()
    {
        float exHeight = 6f;
        RaycastHit2D hitRaycast =  Physics2D.Raycast(bc2d.bounds.center, Vector2.down, bc2d.bounds.extents.y + exHeight, groundLayerMask);
        Color colorRay;
        if (hitRaycast.collider != null)
        {
            colorRay = Color.green;
        }
        else
        {
            colorRay = Color.blue;
        }
        //Debug.DrawRay(bc2d.bounds.center, Vector2.down * (bc2d.bounds.extents.y + exHeight));
        //Debug.Log(hitRaycast.collider);
        return hitRaycast.collider != null;
    }

    void FlipFacing()
    {
        bFlipFacing = !bFlipFacing;
        Vector3 charScale = transform.localScale;
        charScale.x *= -1.0f;
        transform.localScale = charScale;
    }
}
