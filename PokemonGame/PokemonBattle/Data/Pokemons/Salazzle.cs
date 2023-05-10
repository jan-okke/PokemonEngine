using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Salazzle : Pokemon
{
	public override string Name => "Salazzle";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Corrosion() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Oblivious() };
	public override Stats BaseStats => new Stats(68, 64, 60, 111, 60, 117);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Firelash() },
		[1] = new List<Move>() { new Moves.Firelash(), new Moves.Knockoff(), new Moves.Encore(), new Moves.Torment(), new Moves.Swagger(), new Moves.Disable(), new Moves.Scratch(), new Moves.Endeavor(), new Moves.Pound(), new Moves.Poisongas(), new Moves.Smog(), new Moves.Ember() },
		[15] = new List<Move>() { new Moves.Poisonfang() },
		[20] = new List<Move>() { new Moves.Sweetscent() },
		[25] = new List<Move>() { new Moves.Nastyplot() },
		[30] = new List<Move>() { new Moves.Incinerate() },
		[37] = new List<Move>() { new Moves.Venoshock() },
		[44] = new List<Move>() { new Moves.Dragonpulse() },
		[51] = new List<Move>() { new Moves.Venomdrench() },
		[58] = new List<Move>() { new Moves.Flamethrower() },
		[65] = new List<Move>() { new Moves.Toxic() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Attract(), new Moves.Beatup(), new Moves.Breakingswipe(), new Moves.Corrosivegas(), new Moves.Crosspoison(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Fling(), new Moves.Foulplay(), new Moves.Gunkshot(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Leechlife(), new Moves.Nastyplot(), new Moves.Overheat(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Scaleshot(), new Moves.Shadowclaw(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderwave(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Willowisp() };
	public override int Weight => 222;
	public override int ExpYield => 168;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}