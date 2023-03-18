using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zeraora : Pokemon
	{
		public override string Name => "Zeraora";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Voltabsorb() };
		public override Stats BaseStats => new Stats(88, 112, 75, 102, 80, 143);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Poweruppunch(), new Moves.Fakeout(), new Moves.Scratch(), new Moves.Quickattack(), new Moves.Snarl(), new Moves.Spark() },
			[8] = new List<Move>() { new Moves.Furyswipes() },
			[16] = new List<Move>() { new Moves.Quickguard() },
			[24] = new List<Move>() { new Moves.Slash() },
			[32] = new List<Move>() { new Moves.Voltswitch() },
			[40] = new List<Move>() { new Moves.Charge() },
			[48] = new List<Move>() { new Moves.Thunderpunch() },
			[56] = new List<Move>() { new Moves.Honeclaws() },
			[64] = new List<Move>() { new Moves.Discharge() },
			[72] = new List<Move>() { new Moves.Wildcharge() },
			[80] = new List<Move>() { new Moves.Agility() },
			[88] = new List<Move>() { new Moves.Plasmafists() },
			[96] = new List<Move>() { new Moves.Closecombat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Assurance(), new Moves.Aurasphere(), new Moves.Blazekick(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Calmmind(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Drainpunch(), new Moves.Electricterrain(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Outrage(), new Moves.Payday(), new Moves.Playrough(), new Moves.Protect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Swift(), new Moves.Taunt(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Voltswitch(), new Moves.Wildcharge(), new Moves.Workup() };
		public override int Weight => 445;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 3
		};
	}
}