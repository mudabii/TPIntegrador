using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] GameOverScreen deathMenu;
    public GameObject died;
    CharacterController characterController;
    public float gravity = -15f;
    [SerializeField] private float yVelocity = 0f;
    [Range(2f, 20f)]
    public float jumpSpeed = 10f;
    void Start()
    {
        gameObject.SetActive(true);
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Kill"))
        {
            Death();
        }
    }
    void Death()
    {
        Instantiate(died, transform.position, Quaternion.identity);
        deathMenu.ActiveScreenLose();
        GetComponent<CharacterController>().enabled = false;
        gameObject.SetActive(false);
    }

}
