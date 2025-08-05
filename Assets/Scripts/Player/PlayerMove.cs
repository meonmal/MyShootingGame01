using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    /// <summary>
    /// 플레이어 이동 속도
    /// </summary>
    [SerializeField]
    private float moveSpeed;

    /// <summary>
    /// 플레이어 리지드바디2D
    /// </summary>
    private Rigidbody2D rigid;

    private void Awake()
    {
        // 리지드바디2D 가져오기
        rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    /// <summary>
    /// 플레이어를 이동시키는 함수
    /// </summary>
    private void Movement()
    {
        // 플레이어의 이동값을 받은 방향 벡터 생성
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // 방향벡터를 정규화 하여 일정한 이동속도 유지
        Vector3 Pos = new Vector3(moveX, moveY, 0).normalized;

        // 리지드바디2D를 이용해 실제로 움직이게 한다.
        rigid.linearVelocity = Pos * moveSpeed;
    }
}
