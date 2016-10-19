// Source : https://leetcode.com/problems/valid-sudoku/ 
// Author : codeyu 
// Date : Monday, October 17, 2016 7:38:09 PM 

/**********************************************************************************
*
* Determine if a Sudoku is valid, according to: Sudoku Puzzles - The Rules.
* 
* The Sudoku board could be partially filled, where empty cells are filled with the character '.'.
* 
* 
* 
* A partially filled sudoku which is valid.
* 
* 
* Note:
* A valid Sudoku board (partially filled) is not necessarily solvable. Only the filled cells need to be validated.
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution036 
    {
        public static bool IsValidSudoku(char[,] board) 
        {
            if(board.Length != 81 && board.GetLength(0) != 9)
            {
                return false;
            }
            // check Row
            for(int i=0; i<9; i++) {
                ISet<int> existed = new HashSet<int>();
                for(int j=0; j<9; j++) {
                    if(board[i,j] == '.') continue; 
                    int k = board[i,j]-'0';
                    if(k==0 || !existed.Add(k)) return false;
                }
            }
            
            //check Column
            for(int j=0; j<9; j++) {
                ISet<int> existed = new HashSet<int>();
                for(int i=0; i<9; i++) {
                    if(board[i,j] == '.') continue; 
                    int k = board[i,j]-'0';
                    if(k==0 || !existed.Add(k)) return false;
                }
            }
            
            // check Box
            for(int i=0; i<3; i++) {
                for(int j=0; j<3; j++) {
                    int row = 3*i;
                    int col = 3*j;
                    ISet<int> existed = new HashSet<int>();
                    for(int m=row; m<row+3; m++) {
                        for(int n=col; n<col+3; n++) {
                            if(board[m,n] == '.') continue; 
                            int k = board[m,n]-'0';
                            if(k==0 || !existed.Add(k)) return false;
                        }
                    }
                }
            }
            
            return true;
        }
    }
}
