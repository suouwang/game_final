using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class baseball : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    private Rigidbody rb;
    public float hitForce = 500f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = new Vector3(-0.15f, 2.2f, -25.69f);
        Vector3 direction = (target - rb.position).normalized;

        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);

        if (Vector3.Distance(target, rb.position) < 0.1f)
        {
            Debug.Log("到達目標！");
            Destroy(gameObject); // 或觸發爆炸、動畫等
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("擦棒");
        /**/
        if (collision.gameObject.CompareTag("Bat"))
        {
            Vector3 hitDirection = collision.contacts[0].normal * -1f;
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(hitDirection * hitForce);

            Debug.Log("球被打出去！");
        }
    }
}
