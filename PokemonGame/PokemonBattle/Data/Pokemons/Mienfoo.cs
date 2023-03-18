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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Innerfocus(), new Abilities.Regenerator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Reckless() };
		public override Stats BaseStats => new Stats(45, 85, 50, 55, 50, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Pound(), new Moves.Detect() },
			[5] = new List<Move>() { new Moves.Fakeout() },
			[10] = new List<Move>() { new Moves.Reversal() },
			[15] = new List<Move>() { new Moves.Furyswipes() },
			[20] = new List<Move>() { new Moves.Quickguard() },
			[25] = new List<Move>() { new Moves.Forcepalm() },
			[30] = new List<Move>() { new Moves.Uturn() },
			[35] = new List<Move>() { new Moves.Drainpunch() },
			[40] = new List<Move>() { new Moves.Honeclaws() },
			[45] = new List<Move>() { new Moves.Aurasphere() },
			[51] = new List<Move>() { new Moves.Bounce() },
			[55] = new List<Move>() { new Moves.Calmmind() },
			[60] = new List<Move>() { new Moves.Highjumpkick() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Allyswitch(), new Moves.Attract(), new Moves.Aurasphere(), new Moves.Batonpass(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Calmmind(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Dig(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Uturn(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Feint(), new Moves.Focuspunch(), new Moves.Knockoff(), new Moves.Vitalthrow() };
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