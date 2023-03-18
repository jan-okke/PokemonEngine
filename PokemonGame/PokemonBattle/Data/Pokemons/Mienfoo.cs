using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mienfoo : Pokemon
	{
		public override string Name => "Mienfoo";
		public override List<Ability> AvailableAbilities => new() {new Innerfocus(), new Regenerator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Reckless() };
		public override Stats BaseStats => new Stats(45, 85, 50, 65, 55, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Detect() },
			[5] = new List<Move>() { new Fakeout() },
			[10] = new List<Move>() { new Reversal() },
			[15] = new List<Move>() { new Furyswipes() },
			[20] = new List<Move>() { new Quickguard() },
			[25] = new List<Move>() { new Forcepalm() },
			[30] = new List<Move>() { new Uturn() },
			[35] = new List<Move>() { new Drainpunch() },
			[40] = new List<Move>() { new Honeclaws() },
			[45] = new List<Move>() { new Aurasphere() },
			[51] = new List<Move>() { new Bounce() },
			[55] = new List<Move>() { new Calmmind() },
			[60] = new List<Move>() { new Highjumpkick() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Allyswitch(), new Attract(), new Aurasphere(), new Batonpass(), new Bounce(), new Brickbreak(), new Bulkup(), new Calmmind(), new Closecombat(), new Coaching(), new Dig(), new Drainpunch(), new Endure(), new Facade(), new Fling(), new Focusblast(), new Focusenergy(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockslide(), new Rocktomb(), new Round(), new Sleeptalk(), new Snore(), new Stoneedge(), new Substitute(), new Sunnyday(), new Swift(), new Swordsdance(), new Taunt(), new Uturn(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Feint(), new Focuspunch(), new Knockoff(), new Vitalthrow() };
		public override int Weight => 200;
		public override int ExpYield => 70;
		public override int CatchRate => 180;
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