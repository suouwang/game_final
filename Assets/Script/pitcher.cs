using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitcher : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    public GameObject baseball;
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(pitching());
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator pitching()
    {
        while (true)
        {
            animator.SetTrigger("Pitching");
            yield return new WaitForSeconds(0.7f);
            Spawnball();
            yield return new WaitForSeconds(4.3f);
        }
    }

    void Spawnball()
    {
        Vector3 spawnPosition = new Vector3(-0.53f, 2.0f, -4.52f); // 在 (0,1,0) 的位置生成
        Quaternion spawnRotation = Quaternion.Euler(0, 90, 0);  // 無旋轉
        
        Instantiate(baseball, spawnPosition, spawnRotation);
    }
}
