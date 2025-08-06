using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    /// <summary>
    /// ���� �̵� �ӵ�
    /// </summary>
    [SerializeField]
    private float moveSpeed;

    /// <summary>
    /// ���������� �����̴��� Ȯ���ϴ� ����
    /// </summary>
    private bool movingRight = true;

    private void Update()
    {
        DownMove();
        LoopHorizontalMove();
    }

    /// <summary>
    /// ���� �Ʒ��� �����̰� ����� �Լ�
    /// </summary>
    private void DownMove()
    {
        // ���� y��ġ�� 4���� �۰ų� ������
       if(transform.position.y <= 4f)
       {
            // ���� ���
            return;
       }

        // ���� ��ġ���� moveSpeed�� �ӵ� ��ŭ �Ʒ��� �̵���Ų��.
        // �� ������Ʈ�� �Ʒ��� ���ϰ� �ֱ� ������ -�� ���� �ʿ䰡 ����.
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    /// <summary>
    /// �¿�� �Դٰ��� �ϰ� ����� �Լ�
    /// </summary>
    private void LoopHorizontalMove()
    {
        // ���� ���� y��ǥ�� 4���� ���ٸ�
        if(transform.position.y > 4f)
        {
            // ���� ���
            return;
        }

        // movingRight�� true��� ����
        if (movingRight)
        {
            // ���� ������ �������� �����̰� �����.
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime, 0);

            // ���� x��ǥ�� 2.5���� ���ٸ�
            if(transform.position.x >= 2.5f)
            {
                // movingRight�� false�� ����
                movingRight = false;
            }
        }
        // movingRight�� false��� ����
        else
        {
            // ���� ���� �������� �����̰� �����.
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime, 0);

            // ���� x��ǥ�� -2.5���� �۴ٸ�
            if(transform.position.x <= -2.5f)
            {
                // movingRight�� true�� ����
                movingRight = true;
            }
        }
    }
}
