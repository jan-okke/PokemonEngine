using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pawniard : Pokemon
	{
		public override string Name => "Pawniard";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Defiant(), new Abilities.Innerfocus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Pressure() };
		public override Stats BaseStats => new Stats(45, 85, 70, 40, 40, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Scratch(), new Moves.Leer() },
			[5] = new List<Move>() { new Moves.Furycutter() },
			[10] = new List<Move>() { new Moves.Metalclaw() },
			[15] = new List<Move>() { new Moves.Torment() },
			[20] = new List<Move>() { new Moves.Scaryface() },
			[25] = new List<Move>() { new Moves.Assurance() },
			[30] = new List<Move>() { new Moves.Metalsound() },
			[35] = new List<Move>() { new Moves.Slash() },
			[40] = new List<Move>() { new Moves.Nightslash() },
			[45] = new List<Move>() { new Moves.Irondefense() },
			[50] = new List<Move>() { new Moves.Laserfocus() },
			[55] = new List<Move>() { new Moves.Ironhead() },
			[60] = new List<Move>() { new Moves.Swordsdance() },
			[65] = new List<Move>() { new Moves.Guillotine() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Beatup(), new Moves.Brickbreak(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Foulplay(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Lashout(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Psychocut(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Substitute(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderwave(), new Moves.Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Headbutt(), new Moves.Meanlook(), new Moves.Quickguard(), new Moves.Suckerpunch() };
		public override int Weight => 102;
		public override int ExpYield => 68;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}