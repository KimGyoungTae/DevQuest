using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRailGun : MonoBehaviour
{
    public float laserRange = 2f;
    public GameObject laserPrefab;
    [SerializeField]
    private GameObject laserSpawnPoint; // ������ �߻� ��ġ


    void Update()
    {
        // ���콺 Ŭ���� ����
        if (Input.GetMouseButtonDown(0))
        {
            // ������ ����
            ShootLaser();
        }
    }

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


            //// �������� ���� ��ġ���� ǥ��
            //StartCoroutine(ShowLaser(laserSpawnPoint.transform.position, hit.point));

        }
    }

    IEnumerator ShowLaser(Vector3 startPosition, Vector3 endPosition)
    {
        // ������ ���� �� ����
        GameObject laser = Instantiate(laserPrefab, startPosition, Quaternion.identity);
        laser.GetComponent<Rigidbody>().AddForce(transform.forward * 600);
        //LineRenderer lineRenderer = laser.GetComponent<LineRenderer>();
        //lineRenderer.SetPosition(0, startPosition);
        //lineRenderer.SetPosition(1, endPosition);

        // ���� �ð� �� ������ ����
        yield return new WaitForSeconds(0.2f);

        Destroy(laser);
    }
}
