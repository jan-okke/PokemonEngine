using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Deerling : Pokemon
{
	public override string Name => "Deerling";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll(), new Abilities.Sapsipper() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Serenegrace() };
	public override Stats BaseStats => new Stats(60, 60, 50, 40, 50, 75);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Camouflage() },
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
		[41] = new List<Move>() { new Moves.Naturepower() },
		[46] = new List<Move>() { new Moves.Doubleedge() },
		[51] = new List<Move>() { new Moves.Solarbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bounce(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Energyball(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Lastresort(), new Moves.Lightscreen(), new Moves.Naturepower(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Synthesis(), new Moves.Thunderwave(), new Moves.Toxic(), new Moves.Wildcharge(), new Moves.Workup(), new Moves.Worryseed() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Agility(), new Moves.Batonpass(), new Moves.Faketears(), new Moves.Grasswhistle(), new Moves.Headbutt(), new Moves.Naturalgift(), new Moves.Odorsleuth(), new Moves.Sleeptalk(), new Moves.Synthesis(), new Moves.Worryseed() };
	public override int Weight => 195;
	public override int ExpYield => 67;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}