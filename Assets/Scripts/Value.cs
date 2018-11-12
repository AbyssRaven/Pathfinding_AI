﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Random = UnityEngine.Random;

namespace AI_Snakes.Utility
{
    public class Value
    {
        private double _up = 0;
        private double _right = 0;
        private double _down = 0;
        private double _left = 0;


        public void SetValue(Direction dir, double value)
        {
            switch(dir) 
            {
                    case Direction.Up:
                        _up = value;
                        break;
                    case Direction.Right:
                        _right = value;
                        break;
                    case Direction.Down:
                        _down = value;
                        break;
                    case Direction.Left:
                        _left = value;
                        break;
            }
        }
        
        public double GetValue(Direction dir) 
        {
            switch (dir) 
            {
                case Direction.Up:
                    return _up;
                case Direction.Down:
                    return _down;
                case Direction.Right:
                    return _right;
                case Direction.Left:
                    return _left;
                default:
                    return 0;
            }
        }
        
        public Direction ChooseDirectionWithHighestValue() 
        {
            if (_up > _down && _up > _right && _up > _left)
                return Direction.Up;
            if (_right > _up && _right > _down && _right > _left)
                return Direction.Right;
            if (_down > _up && _down > _right && _down > _left)
                return Direction.Down;
            if (_left > _up && _left > _down && _left > _right)
                return Direction.Left;
            return (Direction)Random.Range(0, Enum.GetValues(typeof(Direction)).Length);
        }

        public double GetSumOfValue() 
        {
            return _up + _right + _down + _left;
        }

        public double GetMaxOfAllValue() 
        {
            List<double> value = new List<double> {_up, _right, _down, _left};
            return value.Max();
        }
    }
}
