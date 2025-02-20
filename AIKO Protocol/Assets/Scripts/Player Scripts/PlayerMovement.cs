using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float jumpForce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = Gameobject.Find("Capsule").Getcomponent<"Rigidbody">();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
