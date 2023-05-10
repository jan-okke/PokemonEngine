using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Ariados : Pokemon
{
	public override string Name => "Ariados";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm(), new Abilities.Insomnia() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sniper() };
	public override Stats BaseStats => new Stats(70, 90, 70, 60, 70, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Swordsdance() },
		[1] = new List<Move>() { new Moves.Swordsdance(), new Moves.Focusenergy(), new Moves.Venomdrench(), new Moves.Fellstinger(), new Moves.Bugbite(), new Moves.Poisonsting(), new Moves.Stringshot(), new Moves.Absorb() },
		[5] = new List<Move>() { new Moves.Absorb() },
		[8] = new List<Move>() { new Moves.Infestation() },
		[12] = new List<Move>() { new Moves.Scaryface() },
		[15] = new List<Move>() { new Moves.Nightshade() },
		[19] = new List<Move>() { new Moves.Shadowsneak() },
		[23] = new List<Move>() { new Moves.Furyswipes() },
		[28] = new List<Move>() { new Moves.Suckerpunch() },
		[32] = new List<Move>() { new Moves.Leechlife() },
		[37] = new List<Move>() { new Moves.Agility() },
		[41] = new List<Move>() { new Moves.Pinmissile() },
		[46] = new List<Move>() { new Moves.Psychic() },
		[50] = new List<Move>() { new Moves.Poisonjab() },
		[55] = new List<Move>() { new Moves.Crosspoison() },
		[58] = new List<Move>() { new Moves.Stickyweb() },
		[63] = new List<Move>() { new Moves.Toxicthread() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bounce(), new Moves.Bugbite(), new Moves.Bugbuzz(), new Moves.Confide(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Infestation(), new Moves.Leechlife(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Venoshock(), new Moves.Xscissor() };
	public override int Weight => 335;
	public override int ExpYield => 140;
	public override int CatchRate => 90;
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