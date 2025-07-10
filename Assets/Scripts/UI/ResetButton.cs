using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    private Button _resetBtn;



    // Game Loop Methods---------------------------------------------------------------------------

    private void Awake()
    {
        _resetBtn = GetComponent<Button>();
    }

    private void Start()
    {
        _resetBtn.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        });
    }
}
