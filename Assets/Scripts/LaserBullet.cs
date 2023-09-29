using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System.Threading.Tasks;

public class LaserBullet : MonoBehaviour
{
    
    public GameObject magicPrefab; // ���� Prefab�� �Ҵ��� ����
    private bool hasCollided = false; // �浹 ���¸� ����ϴ� ����

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

            //// �� �ֺ��� ���� ǥ���ϰ� ���� �������� ���� ����
            //StartCoroutine(DropMagicStone(collision.transform.position));

           
            // ���� ��ġ ���� ��������
            Vector3 enemyPosition = collision.gameObject.transform.position;

            // �� �ֺ��� ���� ǥ���ϰ� ���� �������� ���� ����
          //  StartCoroutine(DropMagicStone(enemyPosition));
              MagicMeteros(enemyPosition);

            Destroy(gameObject);
        }
    }


    async void MagicMeteros(Vector3 CollPostion)
    {
        // ���� Prefab�� �ν��Ͻ�ȭ�Ͽ� �� �ֺ��� ����
        GameObject magicInstance = Instantiate(magicPrefab, CollPostion, Quaternion.identity);

        await WaitForSecondsAsync(2f);
        Debug.Log("���׿� ����");

        // ���� ȿ�� �ı�
        Destroy(magicInstance);
    }

    // �񵿱� �������� �����ϴ� �޼ҵ�
    private async Task WaitForSecondsAsync(float seconds)
    {
        await Task.Delay(Mathf.FloorToInt(seconds * 1000));
    }



    // ���� �������� Coroutine
    private IEnumerator DropMagicStone(Vector3 position)
    {
        // ���� Prefab�� �ν��Ͻ�ȭ�Ͽ� �� �ֺ��� ����
        GameObject magicInstance = Instantiate(magicPrefab, position, Quaternion.identity);


        Debug.Log(magicInstance.name); // ���׿� Prefab �̸� ����� ���

        // ���� �ð� ���
        yield return new WaitForSeconds(1.0f);

        // �浹�� �Ǵ��� �������� ��Ʈ���� �ؼ� �� ��Ʈ���� �� �������� ������� �ڷ�ƾ�� ȣ���Ű�� ������ ������ ���峪? -> �� ���ε� �ƴ� �� ����..
        Debug.Log("���׿� ����");

        // ���� ȿ�� �ı�
        Destroy(magicInstance);
    }
}
