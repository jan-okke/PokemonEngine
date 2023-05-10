using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Volbeat : Pokemon
{
	public override string Name => "Volbeat";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Illuminate(), new Abilities.Swarm() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Prankster() };
	public override Stats BaseStats => new Stats(65, 73, 75, 47, 85, 85);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
	public override List<PokemonType> Types => new() {PokemonType.Bug };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Playnice(), new Moves.Tackle() },
		[5] = new List<Move>() { new Moves.Doubleteam() },
		[8] = new List<Move>() { new Moves.Confuseray() },
		[12] = new List<Move>() { new Moves.Quickattack() },
		[15] = new List<Move>() { new Moves.Strugglebug() },
		[19] = new List<Move>() { new Moves.Moonlight() },
		[22] = new List<Move>() { new Moves.Tailglow() },
		[26] = new List<Move>() { new Moves.Encore() },
		[29] = new List<Move>() { new Moves.Protect() },
		[33] = new List<Move>() { new Moves.Zenheadbutt() },
		[36] = new List<Move>() { new Moves.Helpinghand() },
		[40] = new List<Move>() { new Moves.Bugbuzz() },
		[43] = new List<Move>() { new Moves.Playrough() },
		[47] = new List<Move>() { new Moves.Doubleedge() },
		[50] = new List<Move>() { new Moves.Infestation() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bugbite(), new Moves.Bugbuzz(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Infestation(), new Moves.Lightscreen(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Uturn(), new Moves.Waterpulse(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Batonpass(), new Moves.Encore(), new Moves.Lunge(), new Moves.Seismictoss(), new Moves.Trick() };
	public override int Weight => 177;
	public override int ExpYield => 151;
	public override int CatchRate => 150;
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