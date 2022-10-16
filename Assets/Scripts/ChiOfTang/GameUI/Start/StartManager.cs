using ChiOfTang.Data;
using ChiOfTang.Global;
using UnityEngine;
using UnityEngine.UI;

namespace ChiOfTang.GameUI.Start
{
    public class StartManager : MonoBehaviour
    {
        [SerializeField] private Button startGame;

        private void Awake()
        {
            var saveData = new SaveData
            {
                PlayerName = "Chi_Tang",
                PlayerLevel = new PlayerLevel
                {
                    Acc = 1,
                    Level = 0,
                    Score = 100000
                }
            };
            Debug.Log(new GlobalResultSave().Serialize(saveData));
            startGame.onClick.AddListener(StartGame);
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        void StartGame()
        {
        }
    }
}