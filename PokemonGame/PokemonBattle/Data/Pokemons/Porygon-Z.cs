using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Porygonz : Pokemon
{
	public override string Name => "Porygon-Z";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Adaptability(), new Abilities.Download() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Analytic() };
	public override Stats BaseStats => new Stats(85, 80, 70, 135, 75, 90);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Trickroom(), new Moves.Nastyplot(), new Moves.Defensecurl(), new Moves.Tackle(), new Moves.Conversion(), new Moves.Recycle(), new Moves.Magnetrise() },
		[15] = new List<Move>() { new Moves.Thundershock() },
		[20] = new List<Move>() { new Moves.Psybeam() },
		[25] = new List<Move>() { new Moves.Conversion2() },
		[30] = new List<Move>() { new Moves.Agility() },
		[35] = new List<Move>() { new Moves.Recover() },
		[40] = new List<Move>() { new Moves.Discharge() },
		[45] = new List<Move>() { new Moves.Triattack() },
		[50] = new List<Move>() { new Moves.Magiccoat() },
		[55] = new List<Move>() { new Moves.Lockon() },
		[60] = new List<Move>() { new Moves.Zapcannon() },
		[65] = new List<Move>() { new Moves.Hyperbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Allyswitch(), new Moves.Blizzard(), new Moves.Chargebeam(), new Moves.Darkpulse(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Eerieimpulse(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Guardswap(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Nastyplot(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Rest(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Speedswap(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
	public override int Weight => 340;
	public override int ExpYield => 268;
	public override int CatchRate => 30;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 3,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}