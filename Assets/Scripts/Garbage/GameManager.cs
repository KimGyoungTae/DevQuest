//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GameManager : MonoBehaviour
//{
//    // �̱��� �ν��Ͻ�
//    public static GameManager Instance { get; private set; }

//    // �÷��̾� ���� �ν��Ͻ�
//    public PlayerState PlayerState;

//    private void Awake()
//    {
//        // �̱��� ���� ����
//        if (Instance == null)
//        {
//            Instance = this;
//            DontDestroyOnLoad(gameObject);
//        }
//        else
//        {
//            Destroy(gameObject);
//        }

//        // �÷��̾� ���� �ʱ�ȭ
//        // PlayerState = gameObject.AddComponent<PlayerState>();
//    }

//    private void Update()
//    {
//        // �÷��̾� ���� ������Ʈ
//        PlayerState.UpdateState();
//    }
//}
