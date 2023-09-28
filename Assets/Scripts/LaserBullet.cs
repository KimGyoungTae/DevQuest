using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : MonoBehaviour
{
    //private void OnTriggerEnter(Collider other)
    // {
    //     //// �������� �浹�� ��ü�� Layer�� "Enemy"�� ���
    //     //if (other.gameObject.layer == LayerMask.NameToLayer("Enemy"))
    //     //{
    //     //    Debug.Log("�������� ���� �浹�߽��ϴ�!");
    //     //}

    //     if (other.CompareTag("Enemy"))
    //     {
    //         Debug.Log("�������� ���� �浹�߽��ϴ�!");
    //     }
    // }


    // �� ���� Collider�� �浹���� �� ȣ��˴ϴ�.
    private void OnCollisionEnter(Collision collision)
    {
        // �浹�� ��ü�� �±׸� Ȯ���Ͽ� ���ϴ� ������ �����մϴ�.
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // �浹�� ��ü�� Ư�� �±׸� ������ �ִٸ� ���⿡ �ڵ带 �߰��ϼ���.
            Debug.Log("�������� ���� �浹�߽��ϴ�!");
            Destroy(gameObject);
        }
    }
}
