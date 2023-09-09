using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI timeText;
        [SerializeField] private TextMeshProUGUI finalTime;

        [SerializeField] private GameObject gamePanel;
        [SerializeField] private GameObject finishPanel;
        
        public void UpdateTimeText(int time)
        {
            timeText.text = time.ToString();
        }

        public void ShowFinishPanel()
        {
            finalTime.text = "Потраченное время: " +timeText.text;
            gamePanel.SetActive(false);
            finishPanel.SetActive(true);
        }
    }
}