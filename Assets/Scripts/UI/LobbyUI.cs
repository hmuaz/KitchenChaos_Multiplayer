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
    [SerializeField] private LobbyCreateUI lobbyCreateUI;
    [SerializeField] private TMP_InputField joinCodeInputField;
    [SerializeField] private TMP_InputField playerNameInputField;



    private void Awake()
    {
        mainMenuButton.onClick.AddListener(() =>
        {
            KitchenGameLobby.Instance.LeaveLobby();
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
    private void Start()
    {
        Debug.Log(KitchenGameMultiplayer.Instance.GetPlayerName());
        playerNameInputField.text = KitchenGameMultiplayer.Instance.GetPlayerName();
        playerNameInputField.onValueChanged.AddListener((string newName) =>
        {
            KitchenGameMultiplayer.Instance.SetPlayerName(newName);

        });
    }
}
