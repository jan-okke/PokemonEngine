﻿using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Actions
{
    public static class PokemonActions
    {
        public static void LowerStatStage(this Pokemon pokemon, Stat stat, int amount)
        {
            if (amount <= 0) throw new ArgumentException(null, nameof(amount));
            switch (stat)
            {
                case Stat.HP: throw new ArgumentException(null, nameof(stat));
                case Stat.Attack: pokemon.StatStages.Attack -= Math.Min(amount, 6 + pokemon.StatStages.Attack); break;
                case Stat.Defense: pokemon.StatStages.Defense -= Math.Min(amount, 6 + pokemon.StatStages.Defense); break;
                case Stat.SpecialAttack: pokemon.StatStages.SpecialAttack -= Math.Min(amount, 6 + pokemon.StatStages.SpecialAttack); break;
                case Stat.SpecialDefense: pokemon.StatStages.SpecialDefense -= Math.Min(amount, 6 + pokemon.StatStages.SpecialDefense); break;
                case Stat.Speed: pokemon.StatStages.Speed -= Math.Min(amount, 6 + pokemon.StatStages.Speed); break;
            }
        }
        public static void IncreaseStatStage(this Pokemon pokemon, Stat stat, int amount)
        {
            if (amount <= 0) throw new ArgumentException(null, nameof(amount));
            switch (stat)
            {
                case Stat.HP: throw new ArgumentException(null, nameof(stat));
                case Stat.Attack: pokemon.StatStages.Attack += Math.Min(amount, 6 - pokemon.StatStages.Attack); break;
                case Stat.Defense: pokemon.StatStages.Defense += Math.Min(amount, 6 - pokemon.StatStages.Defense); break;
                case Stat.SpecialAttack: pokemon.StatStages.SpecialAttack += Math.Min(amount, 6 - pokemon.StatStages.SpecialAttack); break;
                case Stat.SpecialDefense: pokemon.StatStages.SpecialDefense += Math.Min(amount, 6 - pokemon.StatStages.SpecialDefense); break;
                case Stat.Speed: pokemon.StatStages.Speed += Math.Min(amount, 6 - pokemon.StatStages.Speed); break;
            }
        }

        public static void IncreaseAllStatStagesBy(this Pokemon pokemon, int amount)
        {
            if (amount <= 0) throw new ArgumentException(null, nameof(amount));
            pokemon.IncreaseStatStage(Stat.Attack, amount);
            pokemon.IncreaseStatStage(Stat.Defense, amount);
            pokemon.IncreaseStatStage(Stat.SpecialAttack, amount);
            pokemon.IncreaseStatStage(Stat.SpecialDefense, amount);
            pokemon.IncreaseStatStage(Stat.Speed, amount);
        }

        public static bool Flinch(this Pokemon pokemon)
        {
            if (pokemon.CanFlinch()) 
            {
                pokemon.Flinched = true;
                return true;
            }
            return false;
        }

        public static bool Trap(this Pokemon pokemon)
        {

            if (pokemon.CanTrap())
            {
                pokemon.Trapped = true;
                return true;
            }
            return false;
        }
    }
}