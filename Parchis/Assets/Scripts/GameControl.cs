using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {
    private static GameObject player1, player2;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;
    public static int playerTurn = 0;

    public static bool gameOver = false;

    // Use this for initialization
    void Start () {

        player1 = GameObject.Find("Blue_player");
        player2 = GameObject.Find("Red_player");

        player1.GetComponent<followPath>().moveAllowed = false;
        player2.GetComponent<followPath>().moveAllowed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (player1.GetComponent<followPath>().steps >
            player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<followPath>().moveAllowed = false;
            player1StartWaypoint = player1.GetComponent<followPath>().steps - 1;
        }

        if (player2.GetComponent<followPath>().steps >
            player2StartWaypoint + diceSideThrown)
        {
            player2.GetComponent<followPath>().moveAllowed = false;
            player2StartWaypoint = player2.GetComponent<followPath>().steps - 1;
        }

        if (player1.GetComponent<followPath>().waypointIndex ==
            player1.GetComponent<followPath>().waypoints.Length)
        {
            gameOver = true;
        }

        if (player2.GetComponent<followPath>().waypointIndex ==
            player2.GetComponent<followPath>().waypoints.Length)
        {
            gameOver = true;
        }
    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) {
            case 1:
                player1.GetComponent<followPath>().moveAllowed = true;
                player1.GetComponent<followPath>().player = 1;
                playerTurn = 1;
                break;

            case 2:
                player2.GetComponent<followPath>().moveAllowed = true;
                player1.GetComponent<followPath>().player = 2;
                playerTurn = 2;
                break;
        }
    }
}
