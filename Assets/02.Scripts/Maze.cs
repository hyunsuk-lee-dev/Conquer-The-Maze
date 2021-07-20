using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

public class Maze
{
    private enum Direction
    {
        left,
        right,
        up,
        down
    }

    private const int defaultSize = 10;
    private int width;
    private int height;

    private bool[,] isVisiteds;


    public bool[,] HorizontalWalls { get; private set; }
    public bool[,] VerticalWalls { get; private set; }


    public Maze() : this(defaultSize, defaultSize) { }

    public Maze(int width, int height)
    {
        this.width = width;
        this.height = height;

        isVisiteds = new bool[width, height];

        HorizontalWalls = new bool[width, height - 1];
        for(int i = 0; i < width; i++)
        {
            for(int j = 0; j < height - 1; j++)
            {
                HorizontalWalls[i, j] = true;
            }
        }

        VerticalWalls = new bool[width - 1, height];
        for(int i = 0; i < width - 1; i++)
        {
            for(int j = 0; j < height; j++)
            {
                VerticalWalls[i, j] = true;
            }
        }
    }

    public void Generate()
    {
        Visit(GetRandomInt(width), GetRandomInt(height));
    }

    private void Visit(int x, int y)
    {
        isVisiteds[x, y] = true;

        List<Direction> availableDirection = GetAvailableDirection(x, y);
        Shuffle(availableDirection);

        foreach(Direction direction in availableDirection)
        {
            (int x, int y) neighbor = GetNeighbor(x, y, direction);

            if(!isVisiteds[neighbor.x, neighbor.y])
            {
                RemoveWall(x, y, direction);
                Visit(neighbor.x, neighbor.y);
            }
        }
    }

    private void RemoveWall(int x, int y, Direction direction)
    {
        int targetX = x, targetY = y;
        bool[,] targetWalls;
        switch(direction)
        {
            case Direction.left:
                targetX = x - 1;
                targetWalls = VerticalWalls;
                break;
            case Direction.right:
                targetWalls = VerticalWalls;
                break;
            case Direction.up:
                targetY = y - 1;
                targetWalls = HorizontalWalls;
                break;
            case Direction.down:
            default:
                targetWalls = HorizontalWalls;
                break;
        }

        targetWalls[targetX, targetY] = false;
    }

    private (int, int) GetNeighbor(int x, int y, Direction direction)
    {
        int targetX = x, targetY = y;
        switch(direction)
        {
            case Direction.left:
                targetX = x - 1;
                break;
            case Direction.right:
                targetX = x + 1;
                break;
            case Direction.up:
                targetY = y - 1;
                break;
            case Direction.down:
                targetY = y + 1;
                break;
        }

        return (targetX, targetY);
    }

    private List<Direction> GetAvailableDirection(int x, int y)
    {
        List<Direction> availableDirection = new List<Direction>();

        if(x > 0)
        {
            availableDirection.Add(Direction.left);
        }
        if(y > 0)
        {
            availableDirection.Add(Direction.up);
        }
        if(x < width - 1)
        {
            availableDirection.Add(Direction.right);
        }
        if(y < height - 1)
        {
            availableDirection.Add(Direction.down);
        }

        return availableDirection;
    }

    private int GetRandomInt(int maxExclusive)
    {
        return Random.Range(0, maxExclusive);
    }

    private void Shuffle<T>(List<T> list)
    {
        int n = list.Count;
        while(n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
