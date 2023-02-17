using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Entities
{
    public class Answer
    {
        public int AnswerCode { get; set; }
        public int Value { get; set; }

        public Answer(int answerCode, int value)
        {
            AnswerCode = answerCode;
            Value = value;
        }
    }
}
