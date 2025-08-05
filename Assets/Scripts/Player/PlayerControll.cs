using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [SerializeField]
    private Transform spawnPosition;
    [SerializeField]
    private GameObject bullet;

    private void Update()
    {
        Shoot();
    }

    /// <summary>
    /// 총알 발사 함수
    /// </summary>
    private void Shoot()
    {
        // 마우스 왼쪽버튼 클릭시 실행
        if (Input.GetMouseButtonDown(0))
        {
            // 총알 소환(플레이어의 소환위치에, 회전 없이 소환)
            Instantiate(bullet, spawnPosition.position, Quaternion.identity);
        }
    }
}
