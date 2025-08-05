using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    /// <summary>
    /// ��� �̵� �ӵ�
    /// </summary>
    [SerializeField]
    private float speed;

    /// <summary>
    /// ��� ������
    /// </summary>
    private Renderer BGRenderer;

    private void Awake()
    {
        // ������ ������Ʈ ��������
        BGRenderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        BGScrolling();
    }

    /// <summary>
    /// ��� ���� ��ũ��
    /// </summary>
    private void BGScrolling()
    {
        // ���� ���� moveSpeed�� ���� �־��ش�.
        float moveSpeed = speed * Time.deltaTime;
        // ���׸����� �̿��� y���� �Ʒ��� �����̴� �� ó�� ���̰� �Ѵ�.
        BGRenderer.material.mainTextureOffset += new Vector2(0, -moveSpeed);
    }
}
