using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    private Rigidbody2D rigid;

    private void Awake()
    {
        // Rigidbody2D 가져오기
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    /// <summary>
    /// 총알 이동 함수
    /// </summary>
    private void Move()
    {
        // 리지드바디2D를 이용해서 이동
        rigid.linearVelocity = transform.up * moveSpeed;
    }
}
