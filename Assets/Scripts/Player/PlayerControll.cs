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
    /// �Ѿ� �߻� �Լ�
    /// </summary>
    private void Shoot()
    {
        // ���콺 ���ʹ�ư Ŭ���� ����
        if (Input.GetMouseButtonDown(0))
        {
            // �Ѿ� ��ȯ(�÷��̾��� ��ȯ��ġ��, ȸ�� ���� ��ȯ)
            Instantiate(bullet, spawnPosition.position, Quaternion.identity);
        }
    }
}
