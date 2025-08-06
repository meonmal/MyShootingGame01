using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    /// <summary>
    /// ���� ���� ü��
    /// </summary>
    [SerializeField]
    private float currentHP;
    /// <summary>
    /// ���� �ִ� ü��
    /// </summary>
    [SerializeField]
    private float maxHP;

    /// <summary>
    /// ���� Rigidbody2D
    /// </summary>
    private Rigidbody2D rigid;

    private void Awake()
    {
        // Rigidbody2D ��������
        rigid = GetComponent<Rigidbody2D>();
        // ���� ���� ü���� �ʱ�ȭ�Ѵ�.
        currentHP = maxHP;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // �ڽŰ� ���� ������Ʈ�� �±װ� Bullet�̸� ����
        if (collision.CompareTag("Bullet"))
        {
            // ���� ���� ü���� 1 ����
            currentHP--;
            // ���� ���� ���� ü���� 0���� �۰ų� ���ٸ�
            if(currentHP <= 0)
            {
                // ���� ������Ʈ �ı�
                Destroy(gameObject);
            }
        }
    }
}
