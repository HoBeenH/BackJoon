using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var _testCount = int.Parse(Console.ReadLine());
            var _deck = new List<int>(_testCount);
            var _result = new StringBuilder(_testCount);
            for (var i = 0; i < _testCount; i++)
            {
                var _input = Console.ReadLine();
                switch (_input)
                {
                    case "pop_front":
                        if (_deck.Count == 0)
                            _result.Append("-1\n");
                        else
                        {
                            _result.Append($"{_deck[0]}\n");
                            _deck.RemoveAt(0);
                        }

                        break;
                    case "pop_back":
                        if (_deck.Count == 0)
                            _result.Append("-1\n");
                        else
                        {
                            var _i = _deck.Count - 1;
                            _result.Append($"{_deck[_i]}\n");
                            _deck.RemoveAt(_i);
                        }

                        break;
                    case "size":
                        _result.Append($"{_deck.Count}\n");
                        break;
                    case "empty":
                        _result.Append(_deck.Count == 0 ? $"1\n" : $"0\n");
                        break;
                    case "front":
                        _result.Append(_deck.Count == 0 ? $"-1\n" : $"{_deck[0]}\n");
                        break;
                    case "back":
                        _result.Append(_deck.Count == 0 ? $"-1\n" : $"{_deck[_deck.Count - 1]}\n");
                        break;
                    default:

                        var _split = _input.Split();
                        switch (_split[0])
                        {
                            case "push_front":
                                _deck.Insert(0,int.Parse(_split[1]));
                                break;
                            default:
                                _deck.Add(int.Parse(_split[1]));
                                break;
                        }

                        break;
                }
            }
            Console.Write(_result);
        }
    }
}