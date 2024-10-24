using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Target"){
            Destroy(gameObject);
            Damage.ReduceDamage(40, collision.gameObject);
        }
    }
}
