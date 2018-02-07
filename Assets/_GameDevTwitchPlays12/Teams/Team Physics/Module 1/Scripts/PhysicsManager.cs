using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(PlayerManager), typeof(TerritoryManager), typeof(FactionManager))]
[RequireComponent(typeof(PlayerAction))]
public class PhysicsManager : MonoBehaviour {
    private TerritoryManager territoryManager;
    private PlayerManager playerManager;
    private PlayerAction playerAction;
    private FactionManager factionManager;
    public Timer timerGame;

    private void Awake()
    {
        territoryManager = gameObject.GetComponent<TerritoryManager>();
        playerManager = gameObject.GetComponent<PlayerManager>();
        playerAction = gameObject.GetComponent<PlayerAction>();
        playerAction.m_territoryManager = territoryManager;
        TimerAPI.AddEndGameTimerListener(test);
        timerGame = gameObject.AddComponent<Timer>();
        TimerAPI.LaunchGameTimer(5,timerGame);

        
    }

    private void test(bool end)
    {
        Debug.Log(end);
    }
    // Use this for initialization
    void Start () {
        StartGame();
      
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StartGame()
    {
        territoryManager.GameStart();
    }

    public void CreatePlayer(string playerName)
    {
        playerManager.CreatePlayer(name);
    }

    public void SetCommandFromPlayer(string name, string command)    
    {
        var p = playerManager.GetPlayer(name);
        if (p == null)
        {
            p=playerManager.CreatePlayer(name);
            playerAction.DoAction(command, p);
        }
        else
        {
            playerAction.DoAction(command, p);
        }
    }
    
}
