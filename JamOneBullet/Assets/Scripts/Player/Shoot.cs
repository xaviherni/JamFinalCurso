using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform shootPoint;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shooting();
        }
    }
    private void Shooting()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
    }
}//Class
