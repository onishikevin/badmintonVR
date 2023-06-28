using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeManager : MonoBehaviour
{
    private enum GameMode
    {
        Service,
        Game
    }

    private enum Category
    {
        Singles,
        Doubles
    }
    [Header("Game Zone Mode")]
    [SerializeField]
    private GameMode _gameMode;

    [SerializeField]
    private Category _category;

    [Space]
    [Header("Others")]
    [SerializeField]
    private Transform _servicePosition;

    [SerializeField]
    private Transform _player;

    [SerializeField]
    private GameObject _singlesZone;

    [SerializeField]
    private GameObject _doublesZone;


    private void Start()
    {
        switch (_category)
        {
            case Category.Singles:
                _singlesZone.SetActive(true);
                _doublesZone.SetActive(false);
                break;
            case Category.Doubles:
                _singlesZone.SetActive(false);
                _doublesZone.SetActive(true);
                break;
        }
        switch (_gameMode)
        {
            case GameMode.Service:
                _player.position = _servicePosition.position;
                break;
            case GameMode.Game:
                _player.position = _servicePosition.position;
                break;
        }

    }
}
