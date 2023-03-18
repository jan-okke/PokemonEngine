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
		public override List<Ability> AvailableAbilities => new() {new Voltabsorb() };
		public override Stats BaseStats => new Stats(88, 112, 75, 102, 80, 143);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Poweruppunch(), new Fakeout(), new Scratch(), new Quickattack(), new Snarl(), new Spark() },
			[8] = new List<Move>() { new Furyswipes() },
			[16] = new List<Move>() { new Quickguard() },
			[24] = new List<Move>() { new Slash() },
			[32] = new List<Move>() { new Voltswitch() },
			[40] = new List<Move>() { new Charge() },
			[48] = new List<Move>() { new Thunderpunch() },
			[56] = new List<Move>() { new Honeclaws() },
			[64] = new List<Move>() { new Discharge() },
			[72] = new List<Move>() { new Wildcharge() },
			[80] = new List<Move>() { new Agility() },
			[88] = new List<Move>() { new Plasmafists() },
			[96] = new List<Move>() { new Closecombat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Assurance(), new Aurasphere(), new Blazekick(), new Bounce(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Calmmind(), new Closecombat(), new Coaching(), new Drainpunch(), new Electricterrain(), new Electroball(), new Electroweb(), new Endure(), new Facade(), new Falseswipe(), new Firepunch(), new Fling(), new Focusblast(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Irontail(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Outrage(), new Payday(), new Playrough(), new Protect(), new Rest(), new Revenge(), new Reversal(), new Risingvoltage(), new Round(), new Scaryface(), new Sleeptalk(), new Snarl(), new Snore(), new Substitute(), new Superpower(), new Swift(), new Taunt(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Voltswitch(), new Wildcharge(), new Workup() };
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