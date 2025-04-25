using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] LayerMask solidObjectLayer;
    [SerializeField] LayerMask grassLayer;
    private bool isMoving;
    private Vector2 input;
    void Start()
    {
        isMoving = false;
    }

    void Update()
    {
        if (!isMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");
            if(input.x != 0)
            {
                input.y = 0;
            }
            if (input != Vector2.zero)
            {
                var targetPos = transform.position;
                targetPos.x += input.x;
                targetPos.y += input.y;

                if (IsWalkable(targetPos))
                {
                    StartCoroutine(Move(targetPos));
                }
            }
        }
    }

    IEnumerator Move(Vector2 targetPos)
    {
        isMoving = true;
        while((targetPos-(Vector2)transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPos;
        isMoving = false;

        CheckForEncounters();
    }

    private bool IsWalkable(Vector2 targetPos)
    {
        if(Physics2D.OverlapCircle(targetPos, 0.2f, solidObjectLayer) != null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private void CheckForEncounters()
    {
        if (Physics2D.OverlapCircle(transform.position, 0.2f, grassLayer) != null)
        {
            if(Random.Range(1,101) <= 10)
            {
                Debug.Log("bvattle!");
            }
        }
    }
}
