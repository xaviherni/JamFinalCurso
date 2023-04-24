using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform shootPoint;
    [SerializeField] private int bulletsAvailable = 1;
    [SerializeField] private bool isLoading = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && bulletsAvailable > 0)
        {
            Shooting();
        }
        if (Input.GetKeyDown(KeyCode.E) && !isLoading && bulletsAvailable == 0)
        {
            isLoading = true;
            StartCoroutine(LoadingBullet());
        }
    }
    private void Shooting()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        bulletsAvailable--;
    }

    private IEnumerator LoadingBullet()
    {
        yield return new WaitForSeconds(2.5f);
        bulletsAvailable++;
        isLoading = false;
    }
}//Class
