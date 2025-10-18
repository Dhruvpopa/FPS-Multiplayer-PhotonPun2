using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    public Movement movement;
    public GameObject _camera;
    public string nickName;
    public TextMeshPro nickNameText;

    public void isLocalPlayer()
    {
        movement.enabled = true;
        _camera.SetActive(true);
    }

    [PunRPC]
    public void SetNickName(string _name)
    {
        nickName = _name;
        nickNameText.text = nickName;
    }

    
}
