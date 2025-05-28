using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseball : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 500f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = new Vector3(0.74f, 1.5f, -19.69f);
        Vector3 direction = (target - transform.position).normalized;
        transform.Translate(direction * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(target, transform.position) < 0.1f)
        {
            Debug.Log("到達目標！");
            Destroy(gameObject); // 或觸發爆炸、動畫等
        }
    }
}
