using System;
using UnityEngine;
using UnityEngine.UIElements;

public class FireSysteam : MonoBehaviour
{
    [SerializeField, Header("子彈預製物")]
    private GameObject prefabBullet;
    [SerializeField, Header("子彈生成點")]
    private Transform firePoint;
    [SerializeField,Header("發射速度"), Range(0,3000)]
    private float fireSpeed=500;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) FireBullet();
    }
    private void FireBullet()
    {
     GameObject temp =Instantiate(prefabBullet,firePoint.position,Quaternion.identity);

     temp.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,-fireSpeed))  ;
    }
}