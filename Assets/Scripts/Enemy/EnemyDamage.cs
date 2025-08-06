using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    /// <summary>
    /// 적의 현재 체력
    /// </summary>
    [SerializeField]
    private float currentHP;
    /// <summary>
    /// 적의 최대 체력
    /// </summary>
    [SerializeField]
    private float maxHP;

    /// <summary>
    /// 적의 Rigidbody2D
    /// </summary>
    private Rigidbody2D rigid;

    private void Awake()
    {
        // Rigidbody2D 가져오기
        rigid = GetComponent<Rigidbody2D>();
        // 적의 현재 체력을 초기화한다.
        currentHP = maxHP;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 자신과 닿은 오브젝트의 태그가 Bullet이면 실행
        if (collision.CompareTag("Bullet"))
        {
            // 적의 현재 체력을 1 감소
            currentHP--;
            // 만약 적의 현재 체력이 0보다 작거나 같다면
            if(currentHP <= 0)
            {
                // 적의 오브젝트 파괴
                Destroy(gameObject);
            }
        }
    }
}
