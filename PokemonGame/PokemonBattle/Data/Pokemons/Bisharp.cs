using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bisharp : Pokemon
	{
		public override string Name => "Bisharp";
		public override List<Ability> AvailableAbilities => new() {new Defiant(), new Innerfocus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Pressure() };
		public override Stats BaseStats => new Stats(65, 125, 100, 70, 60, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Metalburst(), new Scratch(), new Leer(), new Furycutter(), new Metalclaw() },
			[15] = new List<Move>() { new Torment() },
			[20] = new List<Move>() { new Scaryface() },
			[25] = new List<Move>() { new Assurance() },
			[30] = new List<Move>() { new Metalsound() },
			[35] = new List<Move>() { new Slash() },
			[40] = new List<Move>() { new Nightslash() },
			[45] = new List<Move>() { new Irondefense() },
			[50] = new List<Move>() { new Laserfocus() },
			[57] = new List<Move>() { new Ironhead() },
			[64] = new List<Move>() { new Swordsdance() },
			[71] = new List<Move>() { new Guillotine() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Airslash(), new Assurance(), new Attract(), new Beatup(), new Brickbreak(), new Darkpulse(), new Dig(), new Endure(), new Facade(), new Falseswipe(), new Fling(), new Focusblast(), new Foulplay(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Lashout(), new Lowkick(), new Lowsweep(), new Payback(), new Poisonjab(), new Protect(), new Psychocut(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Rocktomb(), new Round(), new Sandstorm(), new Scaryface(), new Screech(), new Shadowclaw(), new Sleeptalk(), new Snarl(), new Snore(), new Stealthrock(), new Steelbeam(), new Stoneedge(), new Substitute(), new Swordsdance(), new Taunt(), new Thief(), new Throatchop(), new Thunderwave(), new Xscissor() };
		public override int Weight => 700;
		public override int ExpYield => 172;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}