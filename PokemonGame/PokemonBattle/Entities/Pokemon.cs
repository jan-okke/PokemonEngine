#nullable enable
using System.Collections.Generic;
using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Extensions;
using System.Linq;
using System;
using PokemonGame.PokemonBattle.Exceptions;
using PokemonGame.PokemonBattle.Validation;

namespace PokemonGame.PokemonBattle.Entities;

public class Pokemon
{
    public event OnFaint? OnFaint;
    public event OnGainExp? OnGainExp;
    public event OnLevelUp? OnLevelUp;
    public event OnTakeDamage? OnTakeDamage;
    
    public virtual string Name => "";
    public int Level { get; private set; }
    private int Experience { get; set; }
    public Ability? Ability { get; private set; }
    public virtual List<Ability> AvailableAbilities => new();
    public virtual List<Ability> AvailableHiddenAbilities => new();
    public Item? Item { get; internal set; }
    public List<Move> Moves { get; } = new();
    public virtual Dictionary<int, List<Move>> LevelUpLearnSet => new();
    public virtual List<Move> EggMoves => new();
    public virtual List<Move> TutorMoves => new();
    public virtual Stats BaseStats => new();
    public Stats IVs { get; } = new();
    public Stats EVs { get; } = new();
    public Stats Stats { get; } = new();
    public Stats StatStages { get; } = new();
    public StatusCondition? Status { get; internal set; }
    public List<SecondaryStatusCondition> SecondaryStatusConditions { get; } = new();
    public virtual ExperienceGroup ExperienceGroup { get; }

    public int CurrentHp { get; internal set; }
    public List<Effect> Effects { get; internal set; } = new();
    public virtual List<PokemonType> Types { get; } = new();
    public Gender Gender { get; internal set; }
    public DynamaxState DynamaxState { get; internal set; } = new(0);

    public virtual int Weight { get; internal set; }
    public virtual int ExpYield { get; }

    public virtual Dictionary<Stat, int> EvYield => new()
    {
        [Stat.HP] = 0,
        [Stat.Attack] = 0,
        [Stat.Defense] = 0,
        [Stat.SpecialAttack] = 0,
        [Stat.SpecialDefense] = 0,
        [Stat.Speed] = 0,
    };
    public virtual int CatchRate { get; }

    public bool IsAlive => CurrentHp > 0;
    public bool IsDynamaxed => DynamaxState.Active;
    public bool IsUnderground => false; // TODO
    public bool IsUnderwater => false; // TODO
    public bool IsProtected => Effects.Any(e => e.HasType(EffectType.Protect, EffectType.BanefulBunker));

    public bool IsFlying => false; // TODO
    public bool IsMinimized => false; // TODO

    public bool Flinched { get; internal set; } // TODO this has to be reset at the end of turn lol
    public bool Infatuated { get; internal set; } // in love
    public bool Confused { get; internal set; }
    public bool Trapped { get; internal set; }
    public bool Muted { get; internal set; } // can not use sound moves xd
    public bool Cursed { get; internal set; }
    private int Happiness { get; set; }


    private static Pokemon GetPokemon(string name)
    {
        const string space = "PokemonGame.PokemonBattle.Data.Pokemons";
        var pokemon = Type.GetType($"{space}.{name}");
        if (pokemon == null)
        {
            throw new ArgumentException($"Object name {name} not recognized.", nameof(name));
        }

        if (Activator.CreateInstance(pokemon) is not Pokemon result) throw new NullReferenceException();
        result.Ability = result.AvailableAbilities[0];
        result.CalculateStats();
        result.HealHp();

        DebugConsole.WriteLine(result.IsAlive);

        return result;

    }

    public static Pokemon GetPokemon(string name, int level)
    {
        var pokemon = GetPokemon(name);
        pokemon.Level = level;
        pokemon.CalculateStats();
        pokemon.HealHp();
        foreach (var m in pokemon.GetUpTo4MovesAtLevel(level))
        {
            pokemon.LearnMove(m);
        }

        return pokemon;
    }

    private void LearnMove(Move move, int? indexToReplace = null)
    {
        if (indexToReplace != null && Moves.Count == 4)
        {
            Moves[(int)indexToReplace] = move;
        }
        else
        {
            Moves.Add(move);
        }
        
    }

    public override string ToString()
    {
        return Name;
    }

    public void SetStatus(StatusConditionType condition, int startingTurns)
    {
        if (Status is { IsActive: true })
        {
            throw new StatusAlreadyActiveException();
        }

        Status = new StatusCondition(condition, startingTurns);
    }

    public void Flinch()
    {
        if (this.CanFlinch())
        {
            Flinched = true;
        }
    }

    public void Confuse()
    {
        if (this.CanConfused())
        {
            Confused = true;
        }
    }

    public void LowerStatStage(Stat stat, int amount)
    {
        switch (stat)
        {
            case Stat.HP:
                throw new StatCantBeLoweredException();
            case Stat.Attack:
                if (StatStages.Attack == -6)
                {
                    throw new StatCantBeLoweredException();
                }

                StatStages.Attack -= amount;
                if (StatStages.Attack < -6)
                {
                    StatStages.Attack = -6;
                }

                break;
            case Stat.Defense:
                if (StatStages.Defense == -6)
                {
                    throw new StatCantBeLoweredException();
                }

                StatStages.Defense -= amount;
                if (StatStages.Defense < -6)
                {
                    StatStages.Defense = -6;
                }

                break;
            case Stat.SpecialAttack:
                if (StatStages.SpecialAttack == -6)
                {
                    throw new StatCantBeLoweredException();
                }

                StatStages.SpecialAttack -= amount;
                if (StatStages.SpecialAttack < -6)
                {
                    StatStages.SpecialAttack = -6;
                }

                break;
            case Stat.SpecialDefense:
                if (StatStages.SpecialDefense == -6)
                {
                    throw new StatCantBeLoweredException();
                }

                StatStages.SpecialDefense -= amount;
                if (StatStages.SpecialDefense < -6)
                {
                    StatStages.SpecialDefense = -6;
                }

                break;
            case Stat.Speed:
                if (StatStages.Speed == -6)
                {
                    throw new StatCantBeLoweredException();
                }

                StatStages.Speed -= amount;
                if (StatStages.Speed < -6)
                {
                    StatStages.Speed = -6;
                }

                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(stat), stat, null);
        }
    }

    public void IncreaseStatStage(Stat stat, int amount)
    {
        switch (stat)
        {
            case Stat.HP:
                throw new StatCantBeRaisedException();
            case Stat.Attack:
                if (StatStages.Attack == 6)
                {
                    throw new StatCantBeRaisedException();
                }

                StatStages.Attack += amount;
                if (StatStages.Attack > 6)
                {
                    StatStages.Attack = 6;
                }

                break;
            case Stat.Defense:
                if (StatStages.Defense == 6)
                {
                    throw new StatCantBeRaisedException();
                }

                StatStages.Defense += amount;
                if (StatStages.Defense > 6)
                {
                    StatStages.Defense = 6;
                }

                break;
            case Stat.SpecialAttack:
                if (StatStages.SpecialAttack == 6)
                {
                    throw new StatCantBeRaisedException();
                }

                StatStages.SpecialAttack += amount;
                if (StatStages.SpecialAttack > 6)
                {
                    StatStages.SpecialAttack = 6;
                }

                break;
            case Stat.SpecialDefense:
                if (StatStages.SpecialDefense == 6)
                {
                    throw new StatCantBeRaisedException();
                }

                StatStages.SpecialDefense += amount;
                if (StatStages.SpecialDefense > 6)
                {
                    StatStages.SpecialDefense = 6;
                }

                break;
            case Stat.Speed:
                if (StatStages.Speed == 6)
                {
                    throw new StatCantBeRaisedException();
                }

                StatStages.Speed += amount;
                if (StatStages.Speed > 6)
                {
                    StatStages.Speed = 6;
                }

                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(stat), stat, null);
        }
    }

    public void GiveEffect(EffectType effectType, int turns)
    {
        if (this.HasEffect(effectType))
        {
            throw new PokemonHasEffectAlreadyException();
        }

        Effects.Add(new Effect(effectType, turns));
    }

    public void HealStatusCondition()
    {
        Status = null;
    }

    public void Infatuate(Pokemon attackingPokemon)
    {
        if (this.CanInfatuate(attackingPokemon))
        {
            Infatuated = true;
        }
    }

    public void TakeDamage(int amount, Pokemon dealer)
    {
        CurrentHp -= amount;
        if (CurrentHp >= 0) return;
        CurrentHp = 0;
        OnTakeDamage?.Invoke(this, new OnTakeDamageArgs(amount, dealer));
        Faint(dealer);
    }

    private int TakeDamage(double percentage)
    {
        if (percentage > 1)
        {
            throw new ArgumentException(null, nameof(percentage));
        }

        var damage = Stats.HP * percentage;
        
        TakeDamage((int)damage);
        return (int)damage;
    }
    private void HealHp(double percentage)
    {
        if (percentage > 1)
        {
            throw new ArgumentException(null, nameof(percentage));
        }

        var heal = Stats.HP * percentage;
        
        HealHp((int)heal);
    }

    public void TransferItem(Item attackingPokemonItem, Pokemon defendingPokemon)
    {
        throw new NotImplementedException();
    }

    public void Trap()
    {
        if (this.CanTrap())
        {
            Trapped = true;
        }
    }

    public void IncreaseAllStatStagesBy(int amount)
    {
        IncreaseStatStage(Stat.Attack, amount);
        IncreaseStatStage(Stat.Defense, amount);
        IncreaseStatStage(Stat.SpecialAttack, amount);
        IncreaseStatStage(Stat.SpecialDefense, amount);
        IncreaseStatStage(Stat.Speed, amount);
    }

    public void IncreaseStatStage(SecondaryStat stat, int amount)
    {
        switch (stat)
        {
            case SecondaryStat.Accuracy:
                if (StatStages.Accuracy == 6)
                {
                    throw new StatCantBeRaisedException();
                }

                StatStages.Accuracy += amount;
                if (StatStages.Accuracy > 6)
                {
                    StatStages.Accuracy = 6;
                }

                break;
            case SecondaryStat.Evasion:
                if (StatStages.Evasion == 6)
                {
                    throw new StatCantBeRaisedException();
                }

                StatStages.Evasion += amount;
                if (StatStages.Evasion > 6)
                {
                    StatStages.Evasion = 6;
                }

                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(stat), stat, null);
        }
    }

    public void Curse()
    {
        if (this.CanCursed())
        {
            Cursed = true;
        }
    }

    public void HealHp(int amount)
    {
        CurrentHp += amount;
        if (CurrentHp > Stats.HP)
        {
            CurrentHp = Stats.HP;
        }
    }

    public void HealHp()
    {
        CurrentHp = Stats.HP;
    }

    public void IncreaseRandomAvailableStatBy(int amount)
    {
        throw new NotImplementedException();
    }

    public void Mute()
    {
        if (this.CanMute())
        {
            Muted = true;
        }
    }

    public void LowerStatStage(SecondaryStat stat, int amount)
    {
        switch (stat)
        {
            case SecondaryStat.Accuracy:
                if (StatStages.Accuracy == -6)
                {
                    throw new StatCantBeLoweredException();
                }

                StatStages.Accuracy -= amount;
                if (StatStages.Accuracy < -6)
                {
                    StatStages.Accuracy = -6;
                }

                break;
            case SecondaryStat.Evasion:
                if (StatStages.Evasion == -6)
                {
                    throw new StatCantBeLoweredException();
                }

                StatStages.Evasion -= amount;
                if (StatStages.Evasion < -6)
                {
                    StatStages.Evasion = -6;
                }

                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(stat), stat, null);
        }
    }

    public void OnTurnEnd()
    {
        if (Status is { IsActive: true })
        {
            switch (Status.Condition)
            {
                case StatusConditionType.None:
                    break;
                case StatusConditionType.Burned:
                    if (!this.HasAbility("Guts", "Facade"))
                    {
                        TakeDamage(1.0 / (this.HasAbility("Heatproof") ? 32 : 16));
                    }
                    break;
                case StatusConditionType.Paralyzed:
                    break;
                case StatusConditionType.Frozen:
                    break;
                case StatusConditionType.Poisoned:
                    if (this.HasAbility("Poison Heal"))
                    {
                        HealHp(1.0 / 16);
                    }
                    else
                    {
                        TakeDamage(1.0 / 16);
                    }
                    break;
                case StatusConditionType.BadlyPoisoned:
                    if (this.HasAbility("Poison Heal"))
                    {
                        HealHp(1.0 / 16);
                    }
                    else
                    {
                        TakeDamage((double)Status.CurrentTurn / 16);
                    }
                    break;
                case StatusConditionType.Sleeping:
                    // TODO Nightmare
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Status.OnEndTurn();
        }

        foreach (var condition in SecondaryStatusConditions)
        {
            switch (condition.Condition)
            {
                case SecondaryStatusConditionType.LeechSeed:
                    var dmg = TakeDamage(1.0 / 8);
                    // TODO defender gets healed {dmg}
                    break;
                case SecondaryStatusConditionType.Bind:
                    TakeDamage(1.0 / 8);
                    break;
                case SecondaryStatusConditionType.Clamp:
                    TakeDamage(1.0 / 8);
                    break;
                case SecondaryStatusConditionType.FireSpin:
                    TakeDamage(1.0 / 8);
                    break;
                case SecondaryStatusConditionType.Infestation:
                    TakeDamage(1.0 / 8);
                    break;
                case SecondaryStatusConditionType.MagmaStorm:
                    TakeDamage(1.0 / 8);
                    break;
                case SecondaryStatusConditionType.SandTomb:
                    TakeDamage(1.0 / 8);
                    break;
                case SecondaryStatusConditionType.SnapTrap:
                    TakeDamage(1.0 / 8);
                    break;
                case SecondaryStatusConditionType.ThunderCage:
                    TakeDamage(1.0 / 8);
                    break;
                case SecondaryStatusConditionType.Whirlpool:
                    TakeDamage(1.0 / 8);
                    break;
                case SecondaryStatusConditionType.Wrap:
                    TakeDamage(1.0 / 8);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            {
                
            }
        }

        if (Item != null)
        {
            switch (Item.Name)
            {
                case "Leftovers":
                    HealHp(1.0 / 16);
                    break;
                case "Black Sludge":
                    if (this.HasType(PokemonType.Poison))
                    {
                        HealHp(1.0 / 16);
                        break;
                    }
                    else
                    {
                        TakeDamage(1.0 / 8);
                        break;
                    }
            } 
        }

        Flinched = false;
        // TODO more
        foreach (var effect in Effects)
        {
            if (effect is { IsActive: true, Type: EffectType.AquaRing })
            {
                HealHp(1.0 / 16);
            }
            effect.OnTurnEnd();
        }
        
        // TODO Perish Song
    }

    

    private void Faint(Pokemon killer, bool expShared = false, bool originalTrainer = true, bool luckyEgg = false)
    {
        OnFaint?.Invoke(this, new OnFaintArgs(killer));
        killer.GainExperience(this, expShared, originalTrainer, luckyEgg);
    }

    private void GainExperience(Pokemon defeated, bool expShared, bool originalTrainer, bool luckyEgg)
    {
        double exp = defeated.ExpYield * defeated.Level;
        exp /= 5.0;
        if (expShared)
        {
            exp /= 2;
        }

        var lvMod = Math.Pow((double)(2 * defeated.Level + 10) / (defeated.Level + this.Level + 10), 2.5);

        exp *= lvMod;
        exp += 1;

        if (!originalTrainer)
        {
            exp *= 1.5;
        }

        if (luckyEgg)
        {
            exp *= 1.5;
        }
        
        // TODO 1,2x if past evo level
        
        // TODO 1,2x if affection
        
        // TODO EXP Powers.
        
        GainExperience((int)exp);
    }

    private void GainExperience(int amount)
    {
        OnGainExp?.Invoke(this, new OnGainExpArgs(amount));
        Experience += amount;
        var newLevel = Experience.AsLevel(ExperienceGroup);

        if (newLevel == Level) return;
        OnLevelUp?.Invoke(this, new OnLevelUpArgs(Level, newLevel));
        Level = newLevel;
    }

    public void LowerHappiness(int lowHappinessMod, int midHappinessMod, int highHappinessMod)
    {
        Happiness -= Happiness switch
        {
            < 100 => lowHappinessMod,
            < 200 => midHappinessMod,
            < 255 => highHappinessMod,
            >= 255 => throw new Exception("Invalid Happiness")
        };

        if (Happiness < 0)
        {
            Happiness = 0;
        }
    }
}