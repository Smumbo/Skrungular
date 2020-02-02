using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    public GameObject northWall;
    public GameObject southWall;
    public GameObject eastWall;
    public GameObject westWall;

    public LoseBounds lose;

    private HashSet<GameObject> activeWalls;
    public int maxActiveWalls;

    void Start()
    {
        activeWalls = new HashSet<GameObject>();
    }

    void Update()
    {
        if (!lose.slowDown)
        {
            checkWall(northWall, "up");
            checkWall(southWall, "down");
            checkWall(eastWall, "right");
            checkWall(westWall, "left");
        }
    }

    void checkWall(GameObject wall, string direction)
    {
        if (Input.GetKey(direction) && activeWalls.Count < maxActiveWalls)
        {
            wall.SetActive(true);
            activeWalls.Add(wall);
        }

        if (Input.GetKeyUp(direction))
        {
            wall.SetActive(false);
            activeWalls.Remove(wall);
        }
    }
}
