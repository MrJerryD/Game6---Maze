using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float rotateSpeed = 80f;
    private Rigidbody rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(horizontal, 0, vertical * speed).normalized;
        //rig.velocity = movement * speed;

        // Вращение объекта (ниже вместо Horizontal идет 0, чтобы объект мог на месте поворачиваться)
        if (horizontal != 0)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * horizontal * rotateSpeed);
        }
        Vector3 moveDirection = transform.forward * vertical * speed * Time.deltaTime; // при сталкивании с обьектами, не проходит внутрь (тут помагает физическое свойство в materials)
        rig.MovePosition(transform.position + moveDirection);

    }
}


