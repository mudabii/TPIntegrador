using UnityEngine;

public class Shoot : MonoBehaviour
{
    [Header("References")]
    public Transform attPoint;
    public GameObject bombPrefab;

    [Header("Settings")]
    public float throwCD;

    [Header("Trowing")]
    public KeyCode throwKey = KeyCode.Mouse0;
    public float throwForce;
    public float throwUpwardForce;

    bool readyToThrow;

    private void Start()
    {
        readyToThrow = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(throwKey) && readyToThrow)
        {
            Throw();
        }
    }

    private void Throw()
    {
        readyToThrow = false;

        GameObject projectile = Instantiate(bombPrefab, attPoint.position, transform.rotation);

        Rigidbody projectileRB = projectile.GetComponent<Rigidbody>();

        projectileRB.AddForce(transform.right * throwForce, ForceMode.Impulse);

        Invoke(nameof(ResetThrow), throwCD);
    }

    private void ResetThrow()
    {
        readyToThrow = true;
    }
}
