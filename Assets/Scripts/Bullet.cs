using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int dmg;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<BreakWall>() != null)
        {
            BreakWall breakWall = collision.gameObject.GetComponent<BreakWall>();
            breakWall.TakeDmg(dmg);
            Destroy(gameObject);
        }
    }
}
