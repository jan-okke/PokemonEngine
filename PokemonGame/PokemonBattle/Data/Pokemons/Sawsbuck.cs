using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Sawsbuck : Pokemon
{
	public override string Name => "Sawsbuck";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll(), new Abilities.Sapsipper() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Serenegrace() };
	public override Stats BaseStats => new Stats(80, 100, 70, 60, 70, 95);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Hornleech() },
		[1] = new List<Move>() { new Moves.Hornleech(), new Moves.Megahorn(), new Moves.Tackle(), new Moves.Camouflage(), new Moves.Growl(), new Moves.Sandattack() },
		[4] = new List<Move>() { new Moves.Growl() },
		[7] = new List<Move>() { new Moves.Sandattack() },
		[10] = new List<Move>() { new Moves.Doublekick() },
		[13] = new List<Move>() { new Moves.Leechseed() },
		[16] = new List<Move>() { new Moves.Feintattack() },
		[20] = new List<Move>() { new Moves.Takedown() },
		[24] = new List<Move>() { new Moves.Jumpkick() },
		[28] = new List<Move>() { new Moves.Aromatherapy() },
		[32] = new List<Move>() { new Moves.Energyball() },
		[36] = new List<Move>() { new Moves.Charm() },
		[44] = new List<Move>() { new Moves.Naturepower() },
		[52] = new List<Move>() { new Moves.Doubleedge() },
		[60] = new List<Move>() { new Moves.Solarbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bounce(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Energyball(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lastresort(), new Moves.Lightscreen(), new Moves.Naturepower(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Thunderwave(), new Moves.Toxic(), new Moves.Wildcharge(), new Moves.Workup(), new Moves.Worryseed() };
	public override int Weight => 925;
	public override int ExpYield => 166;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}