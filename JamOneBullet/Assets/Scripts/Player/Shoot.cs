using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform shootPoint;
    [SerializeField] private int bulletsAvailable = 1;
    public float timeReloadRestart;
    public float timeToReload = 2.5f;

    private void Start()
    {
        timeReloadRestart = timeToReload;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && bulletsAvailable > 0)
        {
            Shooting();
        }
        if (Input.GetKey(KeyCode.E))
        {
            LoadAmmo();
        }
    }
    private void Shooting()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        bulletsAvailable--;
    }

    private void LoadAmmo()
    {

        if (timeToReload <= 0 && bulletsAvailable == 0)
        {
            bulletsAvailable++;
        }
    }

}//Class
