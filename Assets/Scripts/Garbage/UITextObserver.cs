//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class UITextObserver : MonoBehaviour, IPlayerStateObserver
//{
//    [SerializeField] private CountDown countDownText;

//    // Start is called before the first frame update
//    void Start()
//    {
//        // �÷��̾� ���� ��ȭ ������ ���� ������ ���
//        GameManager.Instance.PlayerState.OnStateChanged += OnPlayerStateChanged;
//    }

//    public void OnPlayerStateChanged(PlayerState playerState)
//    {
//        // �÷��̾� ���°� ����� ������ ȣ��Ǵ� �޼���
//        UpdateUIText(playerState);
//    }

//    private void UpdateUIText(PlayerState playerState)
//    {
//        // ���⿡�� UI Text�� ������Ʈ�ϴ� ������ �ۼ�
//        // uiText.text = $"HP: {playerState.HP}\nRemain Time: {playerState.RemainTime}\nIs Attack: {playerState.IsAttack}";

//        //countDownText.RemainTimeText.text = $"Remain Time: {countDownText.setTime + playerState.RemainTime}";

//        Debug.Log(playerState.RemainTime);
        
//        countDownText.RemainTimeText.text = "Remain Time : " + countDownText.setTime + playerState.RemainTime;
    
//    }

//}
