using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zorua : Pokemon
	{
		public override string Name => "Zorua";
		public override List<Ability> AvailableAbilities => new() {new Illusion() };
		public override Stats BaseStats => new Stats(40, 65, 40, 80, 40, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Leer() },
			[4] = new List<Move>() { new Torment() },
			[8] = new List<Move>() { new Honeclaws() },
			[12] = new List<Move>() { new Furyswipes() },
			[16] = new List<Move>() { new Scaryface() },
			[20] = new List<Move>() { new Taunt() },
			[24] = new List<Move>() { new Knockoff() },
			[28] = new List<Move>() { new Faketears() },
			[32] = new List<Move>() { new Agility() },
			[36] = new List<Move>() { new Imprison() },
			[40] = new List<Move>() { new Nightdaze() },
			[44] = new List<Move>() { new Nastyplot() },
			[48] = new List<Move>() { new Foulplay() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Assurance(), new Attract(), new Bounce(), new Burningjealousy(), new Calmmind(), new Darkpulse(), new Dig(), new Endure(), new Facade(), new Faketears(), new Fling(), new Foulplay(), new Grassknot(), new Hex(), new Hiddenpower(), new Hypervoice(), new Imprison(), new Lashout(), new Nastyplot(), new Payback(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Round(), new Scaryface(), new Shadowball(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Snarl(), new Snore(), new Substitute(), new Sunnyday(), new Swift(), new Swordsdance(), new Taunt(), new Thief(), new Trick(), new Uproar(), new Uturn() };
		public override List<Move> EggMoves => new List<Move>() { new Copycat(), new Counter(), new Detect(), new Extrasensory(), new Memento(), new Suckerpunch() };
		public override int Weight => 125;
		public override int ExpYield => 66;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}