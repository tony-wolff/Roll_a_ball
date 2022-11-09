using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_script : MonoBehaviour
{
    public float speed = 10.0f;
    Rigidbody m_Rigidbody;
    int _coins = 0;
    // Start is called before the first frame update
    void Start()
    {   
        m_Rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(horizontalInput*speed, 0, verticalInput*speed);

        m_Rigidbody.AddForce(force);
    }

    void OnTriggerEnter(Collider other)
    {   
        _coins++;
        Destroy(other.gameObject);
        UIManager.Instance.UpadeCoinText(_coins);
    }
}
