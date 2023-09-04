using Photon.Pun;
using UnityEngine;

public class RoomMan : MonoBehaviourPunCallbacks
{
    public string roomName = "Room 1";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message: "connecting");
        PhotonNetwork.ConnectUsingSettings();
        
    }
    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        Debug.Log(message: "conected");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();

        PhotonNetwork.JoinRandomOrCreateRoom(roomName, roomOptions: null, typedLobby: null);
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();

        Debug.Log(message: "connected room");

        GameManager.instance.SpawnPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
