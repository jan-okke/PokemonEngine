using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Larvesta : Pokemon
{
	public override string Name => "Larvesta";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Flamebody() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Swarm() };
	public override Stats BaseStats => new Stats(55, 85, 55, 50, 55, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Ember(), new Moves.Stringshot() },
		[6] = new List<Move>() { new Moves.Flamecharge() },
		[12] = new List<Move>() { new Moves.Strugglebug() },
		[18] = new List<Move>() { new Moves.Flamewheel() },
		[24] = new List<Move>() { new Moves.Bugbite() },
		[30] = new List<Move>() { new Moves.Screech() },
		[36] = new List<Move>() { new Moves.Leechlife() },
		[42] = new List<Move>() { new Moves.Bugbuzz() },
		[48] = new List<Move>() { new Moves.Takedown() },
		[54] = new List<Move>() { new Moves.Amnesia() },
		[60] = new List<Move>() { new Moves.Doubleedge() },
		[66] = new List<Move>() { new Moves.Flareblitz() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Bugbuzz(), new Moves.Calmmind(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Gigadrain(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Leechlife(), new Moves.Lightscreen(), new Moves.Overheat(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Screech(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Uturn(), new Moves.Wildcharge(), new Moves.Willowisp(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Absorb(), new Moves.Harden(), new Moves.Thrash() };
	public override int Weight => 288;
	public override int ExpYield => 72;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}