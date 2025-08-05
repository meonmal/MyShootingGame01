using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    /// <summary>
    /// �÷��̾� �̵� �ӵ�
    /// </summary>
    [SerializeField]
    private float moveSpeed;

    /// <summary>
    /// �÷��̾� ������ٵ�2D
    /// </summary>
    private Rigidbody2D rigid;

    private void Awake()
    {
        // ������ٵ�2D ��������
        rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    /// <summary>
    /// �÷��̾ �̵���Ű�� �Լ�
    /// </summary>
    private void Movement()
    {
        // �÷��̾��� �̵����� ���� ���� ���� ����
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // ���⺤�͸� ����ȭ �Ͽ� ������ �̵��ӵ� ����
        Vector3 Pos = new Vector3(moveX, moveY, 0).normalized;

        // ������ٵ�2D�� �̿��� ������ �����̰� �Ѵ�.
        rigid.linearVelocity = Pos * moveSpeed;
    }
}
