
public class PlayerHealth
{
    private float health;

    public PlayerHealth(float health) {
        this.health = health;
    }

    public float GetHealth() {
        return health;
    }

    public void Damage(float damageAmount) {
        health -= damageAmount;
    }
}
