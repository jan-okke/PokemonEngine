using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Kadabra : Pokemon
{
	public override string Name => "Kadabra";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Synchronize(), new Abilities.Innerfocus() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Magicguard() };
	public override Stats BaseStats => new Stats(40, 35, 30, 120, 70, 105);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Confusion() },
		[1] = new List<Move>() { new Moves.Confusion(), new Moves.Kinesis(), new Moves.Disable(), new Moves.Teleport() },
		[5] = new List<Move>() { new Moves.Psybeam() },
		[10] = new List<Move>() { new Moves.Reflect() },
		[15] = new List<Move>() { new Moves.Allyswitch() },
		[20] = new List<Move>() { new Moves.Psychocut() },
		[25] = new List<Move>() { new Moves.Recover() },
		[30] = new List<Move>() { new Moves.Psyshock() },
		[35] = new List<Move>() { new Moves.Psychic() },
		[40] = new List<Move>() { new Moves.Roleplay() },
		[45] = new List<Move>() { new Moves.Futuresight() },
		[50] = new List<Move>() { new Moves.Calmmind() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flash(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Foulplay(), new Moves.Futuresight(), new Moves.Grassknot(), new Moves.Guardswap(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psychocut(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Speedswap(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Triattack(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
	public override int Weight => 565;
	public override int ExpYield => 140;
	public override int CatchRate => 100;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 2,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}