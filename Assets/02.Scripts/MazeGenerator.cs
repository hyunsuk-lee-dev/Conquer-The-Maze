using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;
using UnityEngine.UI;

public class MazeGenerator : MonoBehaviour
{
    private const float wallLength = 100;

    [SerializeField]
    private GameObject horizontalWallPrefab;
    [SerializeField]
    private GameObject verticalWallPrefab;
    [SerializeField]
    private RectTransform canvas;
    [SerializeField]
    private int size;

    private GameObject[,] horizontalWalls;
    private GameObject[,] verticalWalls;


    private void Start()
    {
        Maze maze = new Maze(size, size);
        maze.Generate();

        horizontalWalls = new GameObject[size, size - 1];
        verticalWalls = new GameObject[size - 1, size];

        for(int i = 0; i < size; i++)
        {
            CreateObject(horizontalWallPrefab, i * wallLength, 0, $"Wall Left");
            CreateObject(horizontalWallPrefab, i * wallLength, size * wallLength, $"Wall Right");
            CreateObject(verticalWallPrefab, 0, i * wallLength, $"Wall Up");
            CreateObject(verticalWallPrefab, size * wallLength, i * wallLength, $"Wall Down");
        }

        for(int i = 0; i < size; i++)
        {
            for(int j = 1; j < size; j++)
            {
                if(maze.HorizontalWalls[i, j - 1])
                {
                    horizontalWalls[i, j - 1] = CreateObject(horizontalWallPrefab, i * wallLength, j * wallLength, $"Block");
                }
                if(maze.VerticalWalls[j - 1, i])
                {
                    verticalWalls[j - 1, i] = CreateObject(verticalWallPrefab, j * wallLength, i * wallLength, $"Block");
                }
            }
        }
    }

    private GameObject CreateObject(GameObject prefab, float x, float y, string name = "")
    {
        GameObject createdObject = Instantiate(prefab);
        if(!string.IsNullOrEmpty(name))
        {
            createdObject.name = name;
        }
        RectTransform rectTransform = createdObject.GetComponent<RectTransform>();
        rectTransform.SetParent(canvas);
        rectTransform.anchoredPosition = new Vector2(x, y);

        return createdObject;
    }
}
