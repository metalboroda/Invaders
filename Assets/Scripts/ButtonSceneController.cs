using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSceneController : MonoBehaviour
{
    public void ToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}