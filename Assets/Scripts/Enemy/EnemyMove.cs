using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    private bool movingRight = true;

    private void Update()
    {
        DownMove();
        LoopHorizontalMove();
    }

    private void DownMove()
    {
       if(transform.position.y <= 4f)
       {
            return;
       }

        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    private void LoopHorizontalMove()
    {
        if(transform.position.y > 4f)
        {
            return;
        }

        if (movingRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime, 0);

            if(transform.position.x >= 2.5f)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime, 0);

            if(transform.position.x <= -2.5f)
            {
                movingRight = true;
            }
        }
    }
}
