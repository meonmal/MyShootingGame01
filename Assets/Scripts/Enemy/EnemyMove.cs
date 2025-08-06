using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    /// <summary>
    /// 적의 이동 속도
    /// </summary>
    [SerializeField]
    private float moveSpeed;

    /// <summary>
    /// 오른쪽으로 움직이는지 확인하는 변수
    /// </summary>
    private bool movingRight = true;

    private void Update()
    {
        DownMove();
        LoopHorizontalMove();
    }

    /// <summary>
    /// 적을 아래로 움직이게 만드는 함수
    /// </summary>
    private void DownMove()
    {
        // 현재 y위치가 4보다 작거나 같으면
       if(transform.position.y <= 4f)
       {
            // 실행 취소
            return;
       }

        // 현재 위치에서 moveSpeed의 속도 만큼 아래로 이동시킨다.
        // 적 오브젝트가 아래로 향하고 있기 때문에 -를 붙일 필요가 없다.
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    /// <summary>
    /// 좌우로 왔다갔다 하게 만드는 함수
    /// </summary>
    private void LoopHorizontalMove()
    {
        // 현재 적의 y좌표가 4보다 높다면
        if(transform.position.y > 4f)
        {
            // 실행 취소
            return;
        }

        // movingRight가 true라면 실행
        if (movingRight)
        {
            // 적을 오른쪽 방향으로 움직이게 만든다.
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime, 0);

            // 적의 x좌표가 2.5보다 높다면
            if(transform.position.x >= 2.5f)
            {
                // movingRight를 false로 설정
                movingRight = false;
            }
        }
        // movingRight가 false라면 실행
        else
        {
            // 적을 왼쪽 방향으로 움직이게 만든다.
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime, 0);

            // 적의 x좌표가 -2.5보다 작다면
            if(transform.position.x <= -2.5f)
            {
                // movingRight를 true로 설정
                movingRight = true;
            }
        }
    }
}
