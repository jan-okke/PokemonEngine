using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Remoraid : Pokemon
{
	public override string Name => "Remoraid";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Hustle(), new Abilities.Sniper() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moody() };
	public override Stats BaseStats => new Stats(35, 65, 35, 65, 35, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Watergun(), new Moves.Helpinghand() },
		[4] = new List<Move>() { new Moves.Waterpulse() },
		[8] = new List<Move>() { new Moves.Focusenergy() },
		[12] = new List<Move>() { new Moves.Psybeam() },
		[16] = new List<Move>() { new Moves.Aurorabeam() },
		[20] = new List<Move>() { new Moves.Bubblebeam() },
		[24] = new List<Move>() { new Moves.Lockon() },
		[28] = new List<Move>() { new Moves.Bulletseed() },
		[32] = new List<Move>() { new Moves.Icebeam() },
		[36] = new List<Move>() { new Moves.Hydropump() },
		[40] = new List<Move>() { new Moves.Soak() },
		[44] = new List<Move>() { new Moves.Hyperbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bounce(), new Moves.Brine(), new Moves.Bulletseed(), new Moves.Chargebeam(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Focusenergy(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Round(), new Moves.Scald(), new Moves.Screech(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Thunderwave(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Acidspray(), new Moves.Aurorabeam(), new Moves.Entrainment(), new Moves.Flail(), new Moves.Haze(), new Moves.Mudshot(), new Moves.Octazooka(), new Moves.Rockblast(), new Moves.Screech(), new Moves.Snore(), new Moves.Supersonic(), new Moves.Swift(), new Moves.Waterspout() };
	public override int Weight => 120;
	public override int ExpYield => 60;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}