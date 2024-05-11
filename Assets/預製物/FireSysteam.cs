using UnityEngine;
using UnityEngine.UIElements;

public class FireSysteam : MonoBehaviour
{
    [SerializeField, Header("�l�u�w�s��")]
    private GameObject prefabBullet;
    [SerializeField, Header("�l�u�ͦ��I")]
    private Transform firePoint;
    [SerializeField, Header("�o�g�t��"), Range(0, 3000)]
    private float firespeed = 500;

    private void Awake()
    {
        FireBullet();
        GameObject temp = Instantiate(prefabBullet, firePoint.position,Quaternion.identity);

        temp.GetComponent<Rigidbody>().AddForce(new Vector3( firespeed;
    }

    private void FireBullet()

    [
         GameObject temp = Instantiate(prefabBullet, firePoint.position, Quaternion.identity);

        temp.Getcomponent<Rigidbody>().AddForce(new Vector3(0,0,-firespeed));
        ]
}