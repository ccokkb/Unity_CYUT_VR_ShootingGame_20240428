using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HPPlayer : HPSystem
{
    [SerializeField, Header("����Ϥ�")]
    private Image imghp;
    [SerializeField, Header("�����r")]
    private TMP_Text textHp;

    // Start is called before the first frame update
    private string enemyAttackArea = "�L�ͧ����Z��";
    private float hpMax;

    private void Awake()
    {
        hpMax = hp;
        UpdateUI();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains(enemyAttackArea))
        {
            Damage(50);
        }
    }
    private void UpdateUI()
    {
        imghp.fillAmount=hp/hpMax;
        textHp.text=$"���{hp}/{hpMax}";
    }
    protected override void Damage(float damage)
    {
        if (hp <= 0) return;
        base.Damage(damage);
        UpdateUI();
    }
}
