using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HPPlayer : HPSystem
{
    [SerializeField, Header("血條圖片")]
    private Image imghp;
    [SerializeField, Header("血條文字")]
    private TMP_Text textHp;

    // Start is called before the first frame update
    private string enemyAttackArea = "殭屍攻擊距離";
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
        textHp.text=$"血條{hp}/{hpMax}";
    }
    protected override void Damage(float damage)
    {
        if (hp <= 0) return;
        base.Damage(damage);
        UpdateUI();
    }
}
