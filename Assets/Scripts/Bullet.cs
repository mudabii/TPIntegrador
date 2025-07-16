using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int dmg;
    [SerializeField] public float lifeTime = 5f;
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<BreakWall>() != null)
        {
            BreakWall breakWall = collision.gameObject.GetComponent<BreakWall>();
            breakWall.TakeDmg(dmg);
        }

        Destroy(gameObject);
    }
}
