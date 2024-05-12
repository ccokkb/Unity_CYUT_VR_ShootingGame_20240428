using UnityEngine;

public class HPenemy : HPSystem
{
    private string bulletName = "¤l¼u";
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains(bulletName))
        {
            float attack = collision.gameObject.GetComponent<Bullet>().attack;
            Damage(attack);
        }
    }
    protected override void Dead()
    {
        base.Dead();
        Destroy(gameObject);
    }
}
