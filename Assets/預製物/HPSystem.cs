
using UnityEngine;

public class HPSystem : MonoBehaviour
{
    [SerializeField, Header("��q"), Range(0, 500)]
    protected float hp;

    protected virtual void Damage(float damage)
    {
        hp -= damage;

        if (hp <= 0) Dead();

        print($"<color=#f69>{gameObject.name} ��q: {hp}</color>");
    }
    protected virtual void Dead()
    {
        print($"<color=#f33>{gameObject.name} ���`</color>");
    }
}
