using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Skrelp : Pokemon
{
	public override string Name => "Skrelp";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Poisonpoint(), new Abilities.Poisontouch() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Adaptability() };
	public override Stats BaseStats => new Stats(50, 60, 60, 60, 60, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Smokescreen() },
		[5] = new List<Move>() { new Moves.Acid() },
		[10] = new List<Move>() { new Moves.Watergun() },
		[15] = new List<Move>() { new Moves.Tailwhip() },
		[20] = new List<Move>() { new Moves.Doubleteam() },
		[25] = new List<Move>() { new Moves.Poisontail() },
		[30] = new List<Move>() { new Moves.Waterpulse() },
		[35] = new List<Move>() { new Moves.Toxic() },
		[40] = new List<Move>() { new Moves.Dragonpulse() },
		[45] = new List<Move>() { new Moves.Aquatail() },
		[50] = new List<Move>() { new Moves.Sludgebomb() },
		[55] = new List<Move>() { new Moves.Hydropump() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bounce(), new Moves.Dive(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Flipturn(), new Moves.Gunkshot(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Outrage(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Scaleshot(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Thunderbolt(), new Moves.Toxicspikes(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Waterfall() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Acidarmor(), new Moves.Dragontail(), new Moves.Haze(), new Moves.Twister() };
	public override int Weight => 73;
	public override int ExpYield => 64;
	public override int CatchRate => 225;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}