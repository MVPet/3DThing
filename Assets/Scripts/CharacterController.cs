using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

    public Animator anim;
    public float forwardMove = 0;
    public float horizontalMove = 0;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        anim.SetFloat("Turn", horizontalMove);

        forwardMove = Input.GetAxis("Vertical");
        anim.SetFloat("Forward", forwardMove);
    }
}
