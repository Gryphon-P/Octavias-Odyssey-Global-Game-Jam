using UnityEngine;

public class HealthManager : MonoBehaviour
{


    public int health = 0;
    private int player_hitbox_layer; // Weapon
    private int enemy_hitbox_layer;
    private int player_hurtbox_layer; // Body
    private int enemy_hurtbox_layer;
    private int own_layer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Collects all the layers
        player_hitbox_layer = LayerMask.NameToLayer("PlayerHitbox");
        enemy_hitbox_layer = LayerMask.NameToLayer("EnemyHitbox");
        player_hurtbox_layer = LayerMask.NameToLayer("PlayerHurtbox");
        enemy_hurtbox_layer = LayerMask.NameToLayer("EnemyHurtbox");
        own_layer = gameObject.layer;
        if (own_layer != player_hitbox_layer || own_layer != enemy_hitbox_layer 
            || own_layer != player_hurtbox_layer || own_layer != enemy_hitbox_layer)
        {
            Debug.Log("Entity Type Invalid!");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == player_hitbox_layer || own_layer == enemy_hurtbox_layer)
        {
            health -= 5;
            Debug.Log("Enemy hurt");
        }
        else if (collision.gameObject.layer == enemy_hitbox_layer || own_layer == player_hurtbox_layer)
        {
            health -= 5;
            Debug.Log("Player Hurt");
        }
    }
}
