using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Yveltal : Pokemon
{
	public override string Name => "Yveltal";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Darkaura() };
	public override Stats BaseStats => new Stats(126, 131, 95, 131, 98, 99);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Gust(), new Moves.Doubleteam() },
		[5] = new List<Move>() { new Moves.Taunt() },
		[10] = new List<Move>() { new Moves.Snarl() },
		[15] = new List<Move>() { new Moves.Disable() },
		[20] = new List<Move>() { new Moves.Suckerpunch() },
		[25] = new List<Move>() { new Moves.Tailwind() },
		[30] = new List<Move>() { new Moves.Roost() },
		[35] = new List<Move>() { new Moves.Airslash() },
		[40] = new List<Move>() { new Moves.Darkpulse() },
		[45] = new List<Move>() { new Moves.Psychic() },
		[50] = new List<Move>() { new Moves.Oblivionwing() },
		[55] = new List<Move>() { new Moves.Phantomforce() },
		[60] = new List<Move>() { new Moves.Foulplay() },
		[65] = new List<Move>() { new Moves.Dragonrush() },
		[70] = new List<Move>() { new Moves.Hurricane() },
		[75] = new List<Move>() { new Moves.Focusblast() },
		[80] = new List<Move>() { new Moves.Skyattack() },
		[85] = new List<Move>() { new Moves.Hyperbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Airslash(), new Moves.Bodyslam(), new Moves.Darkpulse(), new Moves.Dragonclaw(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Focusblast(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Lashout(), new Moves.Payback(), new Moves.Phantomforce(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Uturn(), new Moves.Zenheadbutt() };
	public override int Weight => 2030;
	public override int ExpYield => 340;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 3,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}