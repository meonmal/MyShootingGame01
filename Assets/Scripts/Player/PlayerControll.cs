using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    /// <summary>
    /// 공격 쿨타임
    /// </summary>
    [SerializeField]
    private float coolTime;
    /// <summary>
    /// 총알 소환 위치
    /// </summary>
    [SerializeField]
    private Transform spawnPosition;
    /// <summary>
    /// 플레이어가 발사하는 총알 오브젝트
    /// </summary>
    [SerializeField]
    private GameObject bullet;

    /// <summary>
    /// 마지막으로 발사한 시간
    /// </summary>
    private float lastAttack = -Mathf.Infinity;

    private void Update()
    {
        Shoot();
    }

    /// <summary>
    /// 총알 발사 함수
    /// </summary>
    private void Shoot()
    {
        // 만약 현재 시간에서 쿨타임만큼의 시간이 지나지 않았다면
        if(Time.time < lastAttack + coolTime)
        {
            // 실행 취소
            return;
        }

        // 마우스 왼쪽버튼 클릭시, 클릭하는 동안 실행
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {
            // 총알 소환(플레이어의 소환위치에, 회전 없이 소환)
            Instantiate(bullet, spawnPosition.position, Quaternion.identity);
            // 마지막 발사 시간을 지금 시간으로 설정
            lastAttack = Time.time;
        }
    }
}
