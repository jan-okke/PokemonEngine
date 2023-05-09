using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Salandit : Pokemon
{
	public override string Name => "Salandit";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Corrosion() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Oblivious() };
	public override Stats BaseStats => new Stats(48, 44, 40, 71, 40, 77);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Scratch(), new Moves.Poisongas() },
		[5] = new List<Move>() { new Moves.Smog() },
		[10] = new List<Move>() { new Moves.Ember() },
		[15] = new List<Move>() { new Moves.Poisonfang() },
		[20] = new List<Move>() { new Moves.Sweetscent() },
		[25] = new List<Move>() { new Moves.Nastyplot() },
		[30] = new List<Move>() { new Moves.Incinerate() },
		[35] = new List<Move>() { new Moves.Venoshock() },
		[40] = new List<Move>() { new Moves.Dragonpulse() },
		[45] = new List<Move>() { new Moves.Venomdrench() },
		[50] = new List<Move>() { new Moves.Flamethrower() },
		[55] = new List<Move>() { new Moves.Toxic() },
		[60] = new List<Move>() { new Moves.Endeavor() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Beatup(), new Moves.Dragonclaw(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Foulplay(), new Moves.Gunkshot(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Leechlife(), new Moves.Nastyplot(), new Moves.Overheat(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Scaleshot(), new Moves.Shadowclaw(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderwave(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Willowisp() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Belch(), new Moves.Fakeout(), new Moves.Mudslap(), new Moves.Sandattack() };
	public override int Weight => 48;
	public override int ExpYield => 64;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}