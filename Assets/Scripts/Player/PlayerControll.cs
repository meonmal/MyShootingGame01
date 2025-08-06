using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    /// <summary>
    /// ���� ��Ÿ��
    /// </summary>
    [SerializeField]
    private float coolTime;
    /// <summary>
    /// �Ѿ� ��ȯ ��ġ
    /// </summary>
    [SerializeField]
    private Transform spawnPosition;
    /// <summary>
    /// �÷��̾ �߻��ϴ� �Ѿ� ������Ʈ
    /// </summary>
    [SerializeField]
    private GameObject bullet;

    /// <summary>
    /// ���������� �߻��� �ð�
    /// </summary>
    private float lastAttack = -Mathf.Infinity;

    private void Update()
    {
        Shoot();
    }

    /// <summary>
    /// �Ѿ� �߻� �Լ�
    /// </summary>
    private void Shoot()
    {
        // ���� ���� �ð����� ��Ÿ�Ӹ�ŭ�� �ð��� ������ �ʾҴٸ�
        if(Time.time < lastAttack + coolTime)
        {
            // ���� ���
            return;
        }

        // ���콺 ���ʹ�ư Ŭ����, Ŭ���ϴ� ���� ����
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {
            // �Ѿ� ��ȯ(�÷��̾��� ��ȯ��ġ��, ȸ�� ���� ��ȯ)
            Instantiate(bullet, spawnPosition.position, Quaternion.identity);
            // ������ �߻� �ð��� ���� �ð����� ����
            lastAttack = Time.time;
        }
    }
}
