﻿using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Validation;
using PokemonGame.PokemonBattle.Extensions;
using PokemonGame.PokemonBattle.Handles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Actions
{
    public static class PokemonActions
    {
        public static void HealHP(this Pokemon pokemon)
        {
            pokemon.CurrentHP = pokemon.Stats.HP;
        }
        public static void HealHP(this Pokemon pokemon, int amount)
        {
            pokemon.CurrentHP += Math.Min(amount, pokemon.Stats.HP - pokemon.CurrentHP);
        }
        public static void HealStatusCondition(this Pokemon pokemon)
        {
            pokemon.Status = new StatusCondition(StatusConditionType.None, -1);
        }
        public static void TakeDamage(this Pokemon pokemon, int amount)
        {
            pokemon.CurrentHP -= Math.Min(amount, pokemon.CurrentHP);
        }
        public static bool SetStatus(this Pokemon pokemon, StatusConditionType condition, int startingTurns)
        {
            if (!pokemon.CanGetStatusCondition(condition)) return false;
            pokemon.Status = new StatusCondition(condition, startingTurns);
            return true;
        }
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
        public static void LowerStatStage(this Pokemon pokemon, SecondaryStat stat, int amount)
        {
            if (amount <= 0) throw new ArgumentException(null, nameof(amount));
            switch (stat)
            {
                case SecondaryStat.Evasion: pokemon.StatStages.Evasion -= Math.Min(amount, 6 + pokemon.StatStages.Evasion); break;
                case SecondaryStat.Accuracy: pokemon.StatStages.Accuracy -= Math.Min(amount, 6 + pokemon.StatStages.Accuracy); break;
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
        public static void IncreaseStatStage(this Pokemon pokemon, SecondaryStat stat, int amount)
        {
            if (amount <= 0) throw new ArgumentException(null, nameof(amount));
            switch (stat)
            {
                case SecondaryStat.Evasion: pokemon.StatStages.Evasion += Math.Min(amount, 6 - pokemon.StatStages.Evasion); break;
                case SecondaryStat.Accuracy: pokemon.StatStages.Accuracy += Math.Min(amount, 6 - pokemon.StatStages.Accuracy); break;
            }
        }
        public static void IncreaseRandomAvailableStatBy(this Pokemon pokemon, int amount) {
            // this SHOULD NOT cause an infinite loop
            if (pokemon.StatStages.Sum() == 42) throw new Exception("Stats maxed out already");
            while (true) {
                var statNum = new Random().Next(1, 8); // {1 - 5 Attack - Speed} {6 - 7 Accuracy - Evasion}
                switch (statNum) {
                    case 1: if (pokemon.StatStages.Attack < 6) pokemon.IncreaseStatStage(Stat.Attack, amount); return;
                    case 2: if (pokemon.StatStages.Defense < 6) pokemon.IncreaseStatStage(Stat.Defense, amount); return;
                    case 3: if (pokemon.StatStages.SpecialAttack < 6) pokemon.IncreaseStatStage(Stat.SpecialAttack, amount); return;
                    case 4: if (pokemon.StatStages.SpecialDefense < 6) pokemon.IncreaseStatStage(Stat.SpecialDefense, amount); return;
                    case 5: if (pokemon.StatStages.Speed < 6) pokemon.IncreaseStatStage(Stat.Speed, amount); return;
                    case 6: if (pokemon.StatStages.Accuracy < 6) pokemon.IncreaseStatStage(SecondaryStat.Accuracy, amount); return;
                    case 7: if (pokemon.StatStages.Evasion < 6) pokemon.IncreaseStatStage(SecondaryStat.Evasion, amount); return;
                }
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

        public static bool GiveEffect(this Pokemon pokemon, EffectType effectType, int turns) {
            if (pokemon.HasEffect(effectType)) return false;
            pokemon.Effects.Add(new Effect(effectType, turns));
            return true;
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

        public static bool Confuse(this Pokemon pokemon)
        {
            if (pokemon.CanConfused())
            {
                pokemon.Confused = true;
                return true;
            }
            return false;
        }

        public static bool Mute(this Pokemon pokemon)
        {
            if (pokemon.CanMute())
            {
                pokemon.Muted = true;
                return true;
            }
            return false;
        }

        public static bool Infatuate(this Pokemon pokemon, Pokemon sender) {
            if (pokemon.CanInfatuate(sender)) {
                pokemon.Infatuated = true;
                return true;
            }
            return false;
        }

        public static bool Dynamax(this Pokemon pokemon) {
            if (pokemon.CanDynamax()) {
                pokemon.DynamaxState = new DynamaxState();
                return true;
            }
            return false;
        }

        public static void TransferItem(this Pokemon pokemon, Item item, Pokemon target) {
            if (item is null) throw new Exception("No Item was given");
            if (target.Item != null) throw new Exception("Opponent already had an item");
            pokemon.Item = null;
            target.Item = item;
        }
        
        public static bool LearnMove(this Pokemon pokemon, Move move, int indexToReplace = 0) {
            if (pokemon.Moves.Count == 4) {
                pokemon.Moves[indexToReplace] = move;
            }
            else {
                pokemon.Moves.Add(move);
            }
            return true;
        }

        public static void GainExperience(this Pokemon pokemon, int amount) {
            pokemon.Experience += amount;
            if (pokemon.Experience.AsLevel(pokemon.ExperienceGroup) > pokemon.Level) {
                pokemon.OnLevelUp(pokemon.Level, pokemon.Experience.AsLevel(pokemon.ExperienceGroup));
            }
        }
    }
}
