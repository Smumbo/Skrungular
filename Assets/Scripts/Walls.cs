using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    public GameObject northWall;
    public GameObject southWall;
    public GameObject eastWall;
    public GameObject westWall;

    private GameObject waiting;

    public int maxActiveWalls;
    private int activeWalls;

    void Start()
    {
        activeWalls = 0;
    }

    void Update()
    {
        checkWall(northWall, "up");
        checkWall(southWall, "down");
        checkWall(eastWall, "right");
        checkWall(westWall, "left");
    }

    void checkWall(GameObject wall, string direction)
    {
        if (Input.GetKeyDown(direction) && activeWalls < maxActiveWalls)
        {
            wall.SetActive(true);
            activeWalls += 1;
        }

        if (Input.GetKeyUp(direction) && wall.activeSelf)
        {
            if (waiting != null)
            {
                wall.SetActive(false);
                waiting.SetActive(true);
                waiting = null;
            }
            else
            {
                wall.SetActive(false);
                activeWalls -= 1;
            }

        }

        if (Input.GetKey(direction) && !wall.activeSelf && activeWalls == maxActiveWalls)
        {
            waiting = wall;
        }
        else
        {
            waiting = null;
        }
    }
}
