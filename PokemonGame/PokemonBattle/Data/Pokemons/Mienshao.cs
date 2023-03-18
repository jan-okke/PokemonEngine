using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mienshao : Pokemon
	{
		public override string Name => "Mienshao";
		public override List<Ability> AvailableAbilities => new() {new Innerfocus(), new Regenerator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Reckless() };
		public override Stats BaseStats => new Stats(65, 125, 60, 105, 95, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Quickguard(), new Pound(), new Detect(), new Fakeout(), new Reversal() },
			[15] = new List<Move>() { new Furyswipes() },
			[20] = new List<Move>() { new Wideguard() },
			[25] = new List<Move>() { new Forcepalm() },
			[30] = new List<Move>() { new Uturn() },
			[35] = new List<Move>() { new Drainpunch() },
			[40] = new List<Move>() { new Honeclaws() },
			[45] = new List<Move>() { new Aurasphere() },
			[53] = new List<Move>() { new Bounce() },
			[59] = new List<Move>() { new Calmmind() },
			[66] = new List<Move>() { new Highjumpkick() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Allyswitch(), new Assurance(), new Attract(), new Aurasphere(), new Batonpass(), new Blazekick(), new Bounce(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Calmmind(), new Closecombat(), new Coaching(), new Dig(), new Drainpunch(), new Endure(), new Facade(), new Fling(), new Focusblast(), new Focusenergy(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockslide(), new Rocktomb(), new Round(), new Sleeptalk(), new Snore(), new Stoneedge(), new Substitute(), new Sunnyday(), new Swift(), new Swordsdance(), new Taunt(), new Uturn(), new Workup() };
		public override int Weight => 355;
		public override int ExpYield => 179;
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