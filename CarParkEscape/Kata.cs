using System;
using System.Collections.Generic;

namespace CarParkEscape
{
    public class Kata
    {
        private int _currentLevel = 0;

        public string[] escape(int[,] carpark)
        {
            // Code here
            var totalLevels = carpark.GetLength(0);
            var totalPosition = carpark.GetLength(1);
            var temp = new int[totalLevels - 1];
            int currentPosition = 0;
            for (int level = 0; level < totalLevels; level++)
            {
                for (int position = 0; position < totalPosition; position++)
                {
                    if (carpark[level, position] == 1)
                    {
                        temp[level] = position;
                    }

                    if (carpark[level, position] == 2)
                    {
                        _currentLevel = level;
                        currentPosition = position;
                    }
                }
            }

            var paths = new List<string>();
            while (_currentLevel <= totalLevels - 1)
            {
                if (_currentLevel == totalLevels - 1)
                {
                    if (currentPosition == totalPosition - 1)
                    {
                        break;
                    }
                    paths.Add(GetLevelPath(currentPosition, totalPosition - 1));
                }
                else
                {
                    paths.Add(GetLevelPath(currentPosition, temp[_currentLevel]));
                }

                if (_currentLevel == temp.Length)
                {
                    break;
                }
                currentPosition = temp[_currentLevel];
                paths.Add(GetDownPath(temp));
            }

            if (_currentLevel > totalLevels - 1)
            {
                paths.RemoveAt(paths.Count - 1);
            }
            return paths.ToArray();
        }

        private string GetDownPath(int[] temp)
        {
            var distance = 0;
            while (_currentLevel < temp.Length - 1 && temp[_currentLevel] == temp[_currentLevel + 1])
            {
                distance++;
                _currentLevel++;
            }
            _currentLevel++;
            distance++;
            return "D" + distance;
        }

        private string GetLevelPath(int start, int end)
        {
            var distance = start - end;
            if (distance > 0)
            {
                return "L" + Math.Abs(distance);
            }
            else
            {
                return "R" + Math.Abs(distance);
            }
        }
    }
}