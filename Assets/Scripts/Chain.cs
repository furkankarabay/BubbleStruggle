using UnityEngine;

public class Chain : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed = 2f;

    public static bool IsFired = false;

    void Start()
    {
        IsFired = false;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            IsFired = true;
        }
        if (IsFired)
        {
            transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * speed;
        }
        else
        {
            transform.position = player.position;
            transform.localScale = new Vector3(1f, 0, 1f);
        }
    }
}
