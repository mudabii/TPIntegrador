using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    CharacterController characterController;
    public float gravity = -15f;
    [SerializeField] private float yVelocity = 0f;
    [Range(2f, 20f)]
    public float jumpSpeed = 10f;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (characterController.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                yVelocity = jumpSpeed;
            }
            else
            {
                yVelocity = 0f;
            }
        }

        //aplicar gravedad
        yVelocity += gravity * Time.deltaTime;
        characterController.Move(new Vector3(0, yVelocity * Time.deltaTime, 0));
    }
}
