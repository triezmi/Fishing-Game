using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void GoToFishingScene()
    {
        SceneManager.LoadScene("FishingScene");
    }
}