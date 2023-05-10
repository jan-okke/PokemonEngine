namespace PokemonGame.PokemonBattle.Actions;

public static class BattleActions
{
    /*
    public static Battle StartWildBattle(PokemonParty playerParty, string pokemonName, int level)
    {
        var opponent = Pokemon.GetPokemon(pokemonName, level);
        var battle = new Battle(playerParty, new PokemonParty(new List<Pokemon> { opponent }));
        battle.SetFlag(BattleFlag.WildBattle);
        return battle;
    }

    public static Battle StartWildBattle(PokemonParty playerParty, Pokemon pokemon)
    {
        var battle = new Battle(playerParty, new PokemonParty(new List<Pokemon> { pokemon }));
        battle.SetFlag(BattleFlag.WildBattle);
        return battle;
    }

    public static Battle StartTrainerBattle(PokemonParty playerParty, Trainer trainer)
    {
        var battle = new Battle(playerParty, trainer.Party);
        battle.SetFlag(BattleFlag.TrainerBattle);
        battle.OpposingTrainer = trainer;
        return battle;
    }

    public static bool SetTerrain(this Battle battle, TerrainEffect effect, int startingTurns)
    {
        if (battle.Terrain != null && battle.Terrain != null &
            !BattleValidation.CanTerrainChanged(battle.Terrain.Effect, effect)) return false;
        battle.Terrain = new Terrain(effect, startingTurns);
        return true;
    }

    public static bool SetWeather(this Battle battle, WeatherCondition condition, int startingTurns)
    {
        if (battle.Weather != null && battle.Weather != null &
            !BattleValidation.CanWeatherChanged(battle.Weather.Condition, condition)) return false;
        battle.Weather = new Weather(condition, startingTurns);
        return true;
    }

    public static void SetFlag(this Battle battle, BattleFlag flag)
    {
        battle.BattleFlags.Add(flag);
    }

    public static bool UseItem(this Battle battle, Pokemon user, Item item)
    {
        if (item.IsPokeball)
        {
            throw new NotImplementedException();
            
            if (!TryCatchPokemon(target, item, out var p)) return false;
            if (battle.PlayerParty.PokemonCount >= 6)
            {
                //player.PokemonBox.Add(p);
            }
            else
            {
                battle.PlayerParty.AddPokemon(p);
            }

            return true;
            
        }

        if (item.IsMedicine)
        {
            switch (item.Name)
            {
                case "Energy Root":
                    user.HealHP(120);
                    break; // todo lower happiness
                case "Moomoo Milk":
                    user.HealHP(100);
                    break;
                case "Lemonade":
                    user.HealHP(80);
                    break;
                case "Fresh Water":
                    user.HealHP(50);
                    break;
                case "Full Restore":
                    user.HealHP();
                    user.HealStatusCondition();
                    break;
                case "Max Potion":
                    user.HealHP();
                    break;
                case "Hyper Potion":
                    user.HealHP(120);
                    break;
                case "Super Potion":
                    user.HealHP(60);
                    break;
                case "Potion":
                    user.HealHP(20);
                    break;
                case "Full Heal":
                    user.HealStatusCondition();
                    break;
                case "Burn Heal":
                    if (user.HasStatusCondition(StatusConditionType.Burned)) user.HealStatusCondition();
                    break;
                case "Antidote":
                    if (user.HasStatusCondition(StatusConditionType.Poisoned, StatusConditionType.BadlyPoisoned))
                        user.HealStatusCondition();
                    break;
                case "Paralyze Heal":
                    if (user.HasStatusCondition(StatusConditionType.Paralyzed)) user.HealStatusCondition();
                    break;
                case "Ice Heal":
                    if (user.HasStatusCondition(StatusConditionType.Frozen)) user.HealStatusCondition();
                    break;
                default: throw new Exception("Item was unknown medicine.");
            }

            return true;
        }

        if (item.IsXItem)
        {
            switch (item.Name)
            {
                // TODO those item names are not correct i think?
                case "X Attack":
                    user.IncreaseStatStage(Stat.Attack, 2);
                    break;
                case "X Defense":
                    user.IncreaseStatStage(Stat.Defense, 2);
                    break;
                case "X SpAtk":
                    user.IncreaseStatStage(Stat.SpecialAttack, 2);
                    break;
                case "X SpDef":
                    user.IncreaseStatStage(Stat.SpecialDefense, 2);
                    break;
                case "X Speed":
                    user.IncreaseStatStage(Stat.Speed, 2);
                    break;
                case "X Accuracy":
                    user.IncreaseStatStage(SecondaryStat.Accuracy, 2);
                    break;
                default:
                    throw new Exception("Item was unknown X item."); // TODO safeguard effects and such via x items
            }

            return true;
        }

        if (item.IsBerry)
        {
            throw new NotImplementedException(); // TODO
        }

        return false;
    }

    private static bool TryCatchPokemon(Pokemon target, Item ball, out Pokemon p)
    {
        if (ball.HasName("Master Ball"))
        {
            p = target.DeepClone();
            return true;
        }

        p = null;
        return false;
    }

    public static void UseMove(this Battle battle, Pokemon user, Pokemon target, Move move)
    {
        var aiMove = battle.GetBestAiMove();
        if (user.IsFaster(target))
        {
            // Player is faster
            battle.HandleMoveTurn(user, target, move, true);
            if (target.IsAlive)
            {
                battle.HandleMoveTurn(target, user, aiMove, false);
            }
        }
        else
        {
            // AI is faster
            battle.HandleMoveTurn(target, user, aiMove, false);
            if (user.IsAlive)
            {
                battle.HandleMoveTurn(user, target, move, true);
            }
        }

        battle.EndTurn();
    }

    private static void EndTurn(this Battle battle)
    {
        if (!battle.IsOngoing)
        {
            DebugConsole.WriteLine("Battle is over!");
            return;
        }

        battle.Turn++;
        // TODO active battlers might need a fix (can cause to be the new pokemon before its sent out)
        foreach (var p in battle.ActiveBattlers)
        {
            p.OnTurnEnd();
        }
    }

    public static bool SwitchTo(this Battle battle, Pokemon otherPokemon)
    {
        // TODO
        var party = battle.PlayerParty;
        return false;
    }
    */
}