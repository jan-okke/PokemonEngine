using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Gligar : Pokemon
{
	public override string Name => "Gligar";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Hypercutter(), new Abilities.Sandveil() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Immunity() };
	public override Stats BaseStats => new Stats(65, 75, 105, 35, 65, 85);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Poisonsting() },
		[4] = new List<Move>() { new Moves.Sandattack() },
		[7] = new List<Move>() { new Moves.Harden() },
		[10] = new List<Move>() { new Moves.Knockoff() },
		[13] = new List<Move>() { new Moves.Quickattack() },
		[16] = new List<Move>() { new Moves.Furycutter() },
		[19] = new List<Move>() { new Moves.Mudslap() },
		[22] = new List<Move>() { new Moves.Acrobatics() },
		[27] = new List<Move>() { new Moves.Slash() },
		[30] = new List<Move>() { new Moves.Uturn() },
		[35] = new List<Move>() { new Moves.Screech() },
		[40] = new List<Move>() { new Moves.Xscissor() },
		[45] = new List<Move>() { new Moves.Earthquake() },
		[50] = new List<Move>() { new Moves.Swordsdance() },
		[55] = new List<Move>() { new Moves.Guillotine() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Aquatail(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bugbite(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Defog(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Frustration(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roost(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelwing(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Tailwind(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Torment(), new Moves.Uturn(), new Moves.Venoshock(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Agility(), new Moves.Batonpass(), new Moves.Counter(), new Moves.Crosspoison(), new Moves.Doubleedge(), new Moves.Feint(), new Moves.Metalclaw(), new Moves.Nightslash(), new Moves.Poisontail(), new Moves.Powertrick(), new Moves.Sandtomb(), new Moves.Wingattack() };
	public override int Weight => 648;
	public override int ExpYield => 86;
	public override int CatchRate => 60;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}