using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject tower;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (tower != null)
        {
            Vector3 direction = (tower.transform.position - transform.position).normalized;

            transform.position += Time.deltaTime * speed * direction;
        }
    }
}
