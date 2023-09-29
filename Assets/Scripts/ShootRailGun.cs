using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRailGun : MonoBehaviour
{
    public float laserRange = 2f;
    public GameObject laserPrefab; // ������
    [SerializeField]
    private GameObject laserSpawnPoint; // ������ �߻� ��ġ


    void Update()
    {
        // ���콺 Ŭ���� ����
        if (Input.GetMouseButtonDown(0))
        {
            // ������ ����
            // ShootLaser();
            CreateLaser();
        }
    }

    // ����ĳ��Ʈ �浹 üũ
    void ShootLaser()
    {
        // ���� ī�޶󿡼� ���콺 ������ �������� ���� �߻�
        //ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Ray ray = new Ray(laserSpawnPoint.transform.position, laserSpawnPoint.transform.forward);
        RaycastHit hit;

        int enemyLayMask = LayerMask.GetMask("Enemy");

        // �����ɽ�Ʈ �浹 Ȯ��
        if (Physics.Raycast(ray, out hit, 1000f, enemyLayMask))
        {
            Debug.Log("�� ����");
        }
    }

    // Projectile(�߻�ü) �浹 üũ
    void CreateLaser()
    {
        StartCoroutine(ShowLaser(laserSpawnPoint.transform.position));
    }

    IEnumerator ShowLaser(Vector3 startPosition)
    {
        // ������ ���� �� ����
        GameObject laser = Instantiate(laserPrefab, startPosition, Quaternion.Euler(90, 0, 0));
        laser.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
       
        // ���� �ð� �� ������ ����
        yield return new WaitForSeconds(1f);

       
        Destroy(laser);
    }

}
