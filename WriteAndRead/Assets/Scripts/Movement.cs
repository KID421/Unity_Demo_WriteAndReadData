using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float speed = 10;

    public Text textCoin;

    private Rigidbody rig;
    private Animator ani;

    public PlayerData data;

    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
    }

    private void Start()
    {
        textCoin.text = "金幣數量：" + data.coin;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            data.coin++;
            textCoin.text = "金幣數量：" + data.coin;
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");

        rig.MovePosition(transform.position + new Vector3(h, 0, v) * speed * Time.fixedDeltaTime);

        ani.SetBool("走路開關", Mathf.Abs(v) > 0 || Mathf.Abs(h) > 0);
    }
}
