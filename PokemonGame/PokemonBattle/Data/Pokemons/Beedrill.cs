using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Beedrill : Pokemon
{
	public override string Name => "Beedrill";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sniper() };
	public override Stats BaseStats => new Stats(65, 90, 40, 45, 80, 75);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Furyattack() },
		[1] = new List<Move>() { new Moves.Bugbite(), new Moves.Furyattack() },
		[11] = new List<Move>() { new Moves.Furycutter() },
		[14] = new List<Move>() { new Moves.Laserfocus() },
		[17] = new List<Move>() { new Moves.Poisonsting() },
		[20] = new List<Move>() { new Moves.Focusenergy() },
		[23] = new List<Move>() { new Moves.Venoshock() },
		[26] = new List<Move>() { new Moves.Assurance() },
		[29] = new List<Move>() { new Moves.Toxicspikes() },
		[32] = new List<Move>() { new Moves.Pinmissile() },
		[35] = new List<Move>() { new Moves.Poisonjab() },
		[38] = new List<Move>() { new Moves.Agility() },
		[41] = new List<Move>() { new Moves.Endeavor() },
		[44] = new List<Move>() { new Moves.Fellstinger() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bugbite(), new Moves.Confide(), new Moves.Cut(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Drillrun(), new Moves.Electroweb(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Infestation(), new Moves.Knockoff(), new Moves.Laserfocus(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Roost(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Uturn(), new Moves.Venoshock(), new Moves.Xscissor() };
	public override int Weight => 295;
	public override int ExpYield => 198;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}