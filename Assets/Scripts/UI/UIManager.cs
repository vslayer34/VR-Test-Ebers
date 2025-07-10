using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField]
    private ResetButton _resetBtn;



    // Game Loop Methods---------------------------------------------------------------------------

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        else
        {
            Instance = this;
        }
    }

    // Member Methods------------------------------------------------------------------------------

    public void ShowResetButton()
    {
        _resetBtn.gameObject.SetActive(true);
    }
}
