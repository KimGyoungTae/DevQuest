using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    public GameObject quitPanel;
   [SerializeField] private bool isQuitPanelActive = false;


    private void Update()
    {
        // null 체크를 하여 변수가 할당되었는지 확인과 동시에 Q키를 눌렀을 때 Panel 활성화
        if(quitPanel != null && Input.GetKeyDown(KeyCode.Q))
        {
            ActivePanel();
        }

        // 게임 종료 패널이 활성화된 상태에서 Y 키를 누르면 게임 종료
        if (quitPanel != null && quitPanel.activeSelf && Input.GetKeyDown(KeyCode.Y))
        {
            Debug.Log("게임 종료 허락");
            QuitGame(); 
        }

        // L 키를 누를 시 시작 화면 전환
        if (quitPanel != null && quitPanel.activeSelf && Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("시작 씬으로 이동");
            LobyScene();
        }
    }

    // 게임 화면 전환
    public void StartGame()
    {
        SceneManager.LoadScene("Assignment");
        Debug.Log("게임 시작 버튼 클릭");
    }

    public void LobyScene()
    {
        SceneManager.LoadScene("StartScene");
        
        // 시작씬으로 다시 이동 시에 마우스 커서를 보이게 만들고, 마우스 위치 움직임 잠금을 해제한다.
        // 해제하지 않는다면, 다시 씬 이동시에 마우스 커서가 움직이지 않아 버튼을 클릭할 수 없게 된다.
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void QuitGame()
    {
        // 게임 종료

#if   UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; //에디터에서 작동
#else
		Application.Quit(); // 빌드 시 작동
#endif

    }

    public void ActivePanel()
    {
        isQuitPanelActive = !isQuitPanelActive;
        quitPanel.SetActive(isQuitPanelActive);

    }

}
