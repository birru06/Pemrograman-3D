using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerakanplayer : MonoBehaviour
{
    public float kecepatan;
    Rigidbody rb;
    Animator anim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Bergerak();
    }

    void Bergerak()
    {
        float gerak = Input.GetAxis("Horizontal");
        rb.velocity = Vector3.right * gerak * kecepatan;
        anim.SetFloat("kecepatan", Mathf.Abs(gerak), 0.1f, Time.deltaTime);
    }
}
