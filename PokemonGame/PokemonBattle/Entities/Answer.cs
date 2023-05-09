using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Entities;

public class Answer
{
    public int AnswerCode { get; }
    public int Value { get; }

    public Dictionary<string, object> Attributes { get; }

    public Answer(int answerCode, int value)
    {
        AnswerCode = answerCode;
        Value = value;
        Attributes = new Dictionary<string, object>();
    }
}