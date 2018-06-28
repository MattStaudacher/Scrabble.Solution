using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Word
  {
    private int _score;
    private string _word;

    public Word()
    {
      _word = "";
      _score = 0;
    }

    public Word(string word)
    {
      _word = word;
      _score = 0;
    }

    public void SetWord(string word)
    {
      _word = word;
    }

    public void Clear()
    {
      _word = "";
      _score = 0;
    }

    public int Score()
    {
      // A, E, I, O, U, L, N, R, S, T       1
      // D, G                               2
      // B, C, M, P                         3
      // F, H, V, W, Y                      4
      // K                                  5
      // J, X                               8
      // Q, Z                               10
      char[] wordArray = _word.ToUpper().ToCharArray();
      foreach(char c in wordArray)
      {
        switch(c)
        {
          case 'A':
          case 'E':
          case 'I':
          case 'O':
          case 'U':
          case 'L':
          case 'N':
          case 'R':
          case 'S':
          case 'T':
          _score +=1;
          break;
          case 'D':
          case 'G':
          _score +=2;
          break;
          case 'B':
          case 'C':
          case 'M':
          case 'P':
          _score +=3;
          break;
          case 'F':
          case 'H':
          case 'V':
          case 'W':
          case 'Y':
          _score +=4;
          break;
          case 'K':
          _score +=5;
          break;
          case 'J':
          case 'X':
          _score +=8;
          break;
          case 'Q':
          case 'Z':
          _score +=10;
          break;
        }
      }
      return _score;
    }

    //Check if Unit Test setup correctly
    public bool Default()
    {
      return true;
    }
  }
}
