using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

public class BoardScript : MonoBehaviour
{
    [SerializeField]
    int WinCondition; //How many consecutive marks you need to win
    [SerializeField]
    int boardRows;
    [SerializeField]
    int boardColumns;

    private CellScript[,] board; // To store the cell objects


    // Start is called before the first frame update
    void Start()
    {
        PopulateBoard(boardRows, boardColumns);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PopulateBoard(int rows = 3, int columns = 3)
    {
        board = new CellScript[rows,columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                board[i, j] = new CellScript();
            }
        }
    }

    public void CheckVictory()
    {
        int rows = board.GetLength(0);
        int columns = board.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                //board[i, j].playerId
            }
        }
    }


}
