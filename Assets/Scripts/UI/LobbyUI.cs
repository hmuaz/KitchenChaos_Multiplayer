using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LobbyUI : MonoBehaviour
{
    [SerializeField] private Button mainMenuButton;
    [SerializeField] private Button creatLobbyButton;
    [SerializeField] private Button joinLobbyButton;
    [SerializeField] private Button joinCodeButton;
    [SerializeField] private TMP_InputField joinCodeInputField;
    [SerializeField] private LobbyCreateUI lobbyCreateUI;


    private void Awake()
    {
        mainMenuButton.onClick.AddListener(() =>
        {
            Loader.Load(Loader.Scene.MainMenuScene);
        });

        creatLobbyButton.onClick.AddListener(() =>
        {
            lobbyCreateUI.Show();
        });

        joinLobbyButton.onClick.AddListener(() =>
        {
            KitchenGameLobby.Instance.QuickJoin();
        });

        joinCodeButton.onClick.AddListener(() =>
        {
            KitchenGameLobby.Instance.JoinWithCode(joinCodeInputField.text);
        });
    }
}
