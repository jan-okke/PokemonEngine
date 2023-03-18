using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zoroark : Pokemon
	{
		public override string Name => "Zoroark";
		public override List<Ability> AvailableAbilities => new() {new Illusion() };
		public override Stats BaseStats => new Stats(60, 105, 60, 120, 60, 105);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Nightslash() },
			[1] = new List<Move>() { new Nightslash(), new Uturn(), new Scratch(), new Leer(), new Torment(), new Honeclaws() },
			[12] = new List<Move>() { new Furyswipes() },
			[16] = new List<Move>() { new Scaryface() },
			[20] = new List<Move>() { new Taunt() },
			[24] = new List<Move>() { new Knockoff() },
			[28] = new List<Move>() { new Faketears() },
			[34] = new List<Move>() { new Agility() },
			[40] = new List<Move>() { new Imprison() },
			[46] = new List<Move>() { new Nightdaze() },
			[52] = new List<Move>() { new Nastyplot() },
			[58] = new List<Move>() { new Foulplay() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Assurance(), new Attract(), new Bounce(), new Burningjealousy(), new Calmmind(), new Darkpulse(), new Dig(), new Encore(), new Endure(), new Facade(), new Faketears(), new Flamethrower(), new Fling(), new Focusblast(), new Foulplay(), new Gigaimpact(), new Grassknot(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Imprison(), new Lashout(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Nastyplot(), new Payback(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Round(), new Scaryface(), new Shadowball(), new Shadowclaw(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Snarl(), new Snore(), new Substitute(), new Sunnyday(), new Swift(), new Swordsdance(), new Taunt(), new Thief(), new Throatchop(), new Trick(), new Uproar(), new Uturn() };
		public override int Weight => 811;
		public override int ExpYield => 179;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}