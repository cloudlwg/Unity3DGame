
using UnityEngine;
using UnityEngine.SceneManagement;

public class Done_Touch : MonoBehaviour
{
    //开始游戏按钮
    public void OnStartGameButton(int indexScene)
    {
        //异步加载场景
        SceneManager.LoadScene(indexScene);
    }

    //退出游戏按钮
    public void OnExitGameButton()
    {
        //退出游戏
        Application.Quit();
    }
}
