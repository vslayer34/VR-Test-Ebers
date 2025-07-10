using UnityEngine;

public class TestSphere : MonoBehaviour, IThrowable
{
    // Interface Methods---------------------------------------------------------------------------
    public void ShowEndGame()
    {
        UIManager.Instance.ShowResetButton();
        AudioManager.Instance.PlayVictorySound();
    }
}
