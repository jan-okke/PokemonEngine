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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Illusion() };
		public override Stats BaseStats => new Stats(40, 65, 40, 80, 40, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Scratch(), new Moves.Leer() },
			[4] = new List<Move>() { new Moves.Torment() },
			[8] = new List<Move>() { new Moves.Honeclaws() },
			[12] = new List<Move>() { new Moves.Furyswipes() },
			[16] = new List<Move>() { new Moves.Scaryface() },
			[20] = new List<Move>() { new Moves.Taunt() },
			[24] = new List<Move>() { new Moves.Knockoff() },
			[28] = new List<Move>() { new Moves.Faketears() },
			[32] = new List<Move>() { new Moves.Agility() },
			[36] = new List<Move>() { new Moves.Imprison() },
			[40] = new List<Move>() { new Moves.Nightdaze() },
			[44] = new List<Move>() { new Moves.Nastyplot() },
			[48] = new List<Move>() { new Moves.Foulplay() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bounce(), new Moves.Burningjealousy(), new Moves.Calmmind(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fling(), new Moves.Foulplay(), new Moves.Grassknot(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Imprison(), new Moves.Lashout(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Round(), new Moves.Scaryface(), new Moves.Shadowball(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snarl(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Trick(), new Moves.Uproar(), new Moves.Uturn() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Copycat(), new Moves.Counter(), new Moves.Detect(), new Moves.Extrasensory(), new Moves.Memento(), new Moves.Suckerpunch() };
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