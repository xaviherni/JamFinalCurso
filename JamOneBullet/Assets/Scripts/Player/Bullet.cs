using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float speed;

    public static Action OnScore;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rb2d.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
        Destroy(this.gameObject, 1.5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            OnScore?.Invoke();
            Destroy(this.gameObject);
        }
    }

}//Class
