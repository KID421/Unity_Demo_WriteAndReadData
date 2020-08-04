using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [Header("移動速度")]
    public float speed = 10;
    [Header("旋轉速度")]
    public float turn = 10;

    private Rigidbody rig;
    private Animator ani;
    private Text textCoin;

    [HideInInspector]
    public int coin;

    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();

        textCoin = GameObject.Find("金幣數量").GetComponent<Text>();
    }

    private void Update()
    {
        Turn();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        Vector3 move = transform.forward * v + transform.right * h;

        rig.MovePosition(transform.position + move * Time.fixedDeltaTime * speed);

        ani.SetBool("走路開關", v != 0 || h != 0);
    }

    private void Turn()
    {
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX * turn * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "金幣")
        {
            coin++;
            textCoin.text = "金幣數量：" + coin;
            Destroy(other.gameObject);
        }
    }
}
