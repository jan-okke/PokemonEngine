using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Hawlucha : Pokemon
	{
		public override string Name => "Hawlucha";
		public override List<Ability> AvailableAbilities => new() {new Limber(), new Unburden() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moldbreaker() };
		public override Stats BaseStats => new Stats(78, 92, 75, 118, 74, 63);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fighting, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Honeclaws() },
			[4] = new List<Move>() { new Wingattack() },
			[8] = new List<Move>() { new Detect() },
			[12] = new List<Move>() { new Aerialace() },
			[16] = new List<Move>() { new Encore() },
			[20] = new List<Move>() { new Featherdance() },
			[24] = new List<Move>() { new Submission() },
			[28] = new List<Move>() { new Bounce() },
			[32] = new List<Move>() { new Taunt() },
			[36] = new List<Move>() { new Roost() },
			[40] = new List<Move>() { new Swordsdance() },
			[44] = new List<Move>() { new Flyingpress() },
			[48] = new List<Move>() { new Highjumpkick() },
			[52] = new List<Move>() { new Endeavor() },
			[56] = new List<Move>() { new Skyattack() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Allyswitch(), new Assurance(), new Attract(), new Batonpass(), new Bodypress(), new Bounce(), new Bravebird(), new Brickbreak(), new Bulkup(), new Closecombat(), new Coaching(), new Dig(), new Drainpunch(), new Dualwingbeat(), new Encore(), new Endure(), new Facade(), new Falseswipe(), new Firepunch(), new Fling(), new Fly(), new Focusblast(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Ironhead(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockslide(), new Rocktomb(), new Round(), new Sleeptalk(), new Snore(), new Steelwing(), new Stoneedge(), new Substitute(), new Sunnyday(), new Superpower(), new Swift(), new Swordsdance(), new Taunt(), new Throatchop(), new Thunderpunch(), new Uturn(), new Workup(), new Xscissor(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Crosschop(), new Defog(), new Entrainment(), new Feint(), new Meanlook(), new Quickguard() };
		public override int Weight => 215;
		public override int ExpYield => 175;
		public override int CatchRate => 100;
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