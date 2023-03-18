using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Passimian : Pokemon
	{
		public override string Name => "Passimian";
		public override List<Ability> AvailableAbilities => new() {new Receiver() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Defiant() };
		public override Stats BaseStats => new Stats(100, 120, 90, 40, 60, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Leer() },
			[5] = new List<Move>() { new Rocksmash() },
			[10] = new List<Move>() { new Focusenergy() },
			[15] = new List<Move>() { new Beatup() },
			[20] = new List<Move>() { new Scaryface() },
			[25] = new List<Move>() { new Takedown() },
			[30] = new List<Move>() { new Fling() },
			[35] = new List<Move>() { new Bulkup() },
			[40] = new List<Move>() { new Thrash() },
			[45] = new List<Move>() { new Doubleedge() },
			[50] = new List<Move>() { new Closecombat() },
			[55] = new List<Move>() { new Reversal() },
			[60] = new List<Move>() { new Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Assurance(), new Attract(), new Beatup(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Closecombat(), new Coaching(), new Drainpunch(), new Earthquake(), new Electroweb(), new Endure(), new Energyball(), new Facade(), new Fling(), new Focusblast(), new Focusenergy(), new Gigaimpact(), new Grassknot(), new Gunkshot(), new Gyroball(), new Hiddenpower(), new Hyperbeam(), new Ironhead(), new Irontail(), new Lowsweep(), new Megakick(), new Megapunch(), new Payback(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockslide(), new Rocktomb(), new Round(), new Scaryface(), new Seedbomb(), new Shadowball(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Superpower(), new Taunt(), new Thief(), new Uproar(), new Uturn(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Counter(), new Feint(), new Knockoff(), new Quickattack(), new Quickguard(), new Seismictoss(), new Vitalthrow() };
		public override int Weight => 828;
		public override int ExpYield => 172;
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