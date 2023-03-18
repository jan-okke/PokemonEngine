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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Defiant(), new Abilities.Innerfocus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Pressure() };
		public override Stats BaseStats => new Stats(65, 125, 100, 60, 70, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Metalburst(), new Moves.Scratch(), new Moves.Leer(), new Moves.Furycutter(), new Moves.Metalclaw() },
			[15] = new List<Move>() { new Moves.Torment() },
			[20] = new List<Move>() { new Moves.Scaryface() },
			[25] = new List<Move>() { new Moves.Assurance() },
			[30] = new List<Move>() { new Moves.Metalsound() },
			[35] = new List<Move>() { new Moves.Slash() },
			[40] = new List<Move>() { new Moves.Nightslash() },
			[45] = new List<Move>() { new Moves.Irondefense() },
			[50] = new List<Move>() { new Moves.Laserfocus() },
			[57] = new List<Move>() { new Moves.Ironhead() },
			[64] = new List<Move>() { new Moves.Swordsdance() },
			[71] = new List<Move>() { new Moves.Guillotine() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Airslash(), new Moves.Assurance(), new Moves.Attract(), new Moves.Beatup(), new Moves.Brickbreak(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Lashout(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Psychocut(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderwave(), new Moves.Xscissor() };
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