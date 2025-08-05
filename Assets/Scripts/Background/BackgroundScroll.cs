using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    /// <summary>
    /// 배경 이동 속도
    /// </summary>
    [SerializeField]
    private float speed;

    /// <summary>
    /// 배경 렌더러
    /// </summary>
    private Renderer BGRenderer;

    private void Awake()
    {
        // 렌더러 컴포넌트 가져오기
        BGRenderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        BGScrolling();
    }

    /// <summary>
    /// 배경 무한 스크롤
    /// </summary>
    private void BGScrolling()
    {
        // 지역 변수 moveSpeed에 값을 넣어준다.
        float moveSpeed = speed * Time.deltaTime;
        // 머테리얼을 이용해 y축이 아래로 움직이는 것 처럼 보이게 한다.
        BGRenderer.material.mainTextureOffset += new Vector2(0, -moveSpeed);
    }
}
