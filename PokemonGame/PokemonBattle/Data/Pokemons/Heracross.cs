using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Heracross : Pokemon
	{
		public override string Name => "Heracross";
		public override List<Ability> AvailableAbilities => new() {new Swarm(), new Guts() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moxie() };
		public override Stats BaseStats => new Stats(80, 125, 75, 40, 95, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Leer() },
			[5] = new List<Move>() { new Furyattack() },
			[10] = new List<Move>() { new Endure() },
			[15] = new List<Move>() { new Aerialace() },
			[20] = new List<Move>() { new Hornattack() },
			[25] = new List<Move>() { new Counter() },
			[30] = new List<Move>() { new Brickbreak() },
			[35] = new List<Move>() { new Pinmissile() },
			[40] = new List<Move>() { new Throatchop() },
			[45] = new List<Move>() { new Thrash() },
			[50] = new List<Move>() { new Swordsdance() },
			[55] = new List<Move>() { new Megahorn() },
			[60] = new List<Move>() { new Closecombat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Assurance(), new Attract(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Bulletseed(), new Closecombat(), new Coaching(), new Cut(), new Dig(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Irondefense(), new Lowkick(), new Megahorn(), new Pinmissile(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockblast(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Shadowclaw(), new Sleeptalk(), new Smartstrike(), new Snore(), new Spikes(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Thief(), new Throatchop(), new Venoshock(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Doubleedge(), new Feint(), new Flail(), new Harden(), new Megahorn(), new Nightslash(), new Revenge(), new Rockblast(), new Seismictoss(), new Takedown() };
		public override int Weight => 540;
		public override int ExpYield => 175;
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