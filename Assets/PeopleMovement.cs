using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class PeopleMovement 
{
    private static PeopleMovement instance;
    private List<GameObject> goals = new List<GameObject>();
    private List<GameObject> obstacles = new List<GameObject>();
    public List<GameObject> Goals
    {
        get
        {
            return goals;
        }
    }

    public List<GameObject> Obstacles
    {
        get
        {
            return Obstacles;
        }
    }

    public static PeopleMovement SingleTon
    {
        get
        {
            if (instance == null)
            {
                instance = new PeopleMovement();
                instance.Goals.AddRange(GameObject.FindGameObjectsWithTag("goal"));
            }
            return instance;
        }
    }
    public void AddObstacles(GameObject gameObstacles)
    {
        obstacles.Add(gameObstacles);
    }
    public void removeObstacles(GameObject gameObstacles)
    {
        int index =  obstacles.IndexOf(gameObstacles);
        obstacles.RemoveAt(index);
        GameObject.Destroy(gameObstacles);
    }
    public GameObject GetRandomGoalPos()
    {
        int index= Random.Range(0, goals.Count);
        return goals[index];
    }
}
