using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    private Rigidbody2D rigid;

    private void Awake()
    {
        // Rigidbody2D ��������
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    /// <summary>
    /// �Ѿ� �̵� �Լ�
    /// </summary>
    private void Move()
    {
        // ������ٵ�2D�� �̿��ؼ� �̵�
        rigid.linearVelocity = transform.up * moveSpeed;
    }
}
